 
# 参考资料：https://www.cnblogs.com/Adoni/p/12370642.html  #
# 开源地址：https://github.com/jbogard/MediatR #
# 依赖注入：https://github.com/jbogard/MediatR.Extensions.Microsoft.DependencyInjection #

# MediatR 会分派两种消息 #
> 1:单播:请求/响应消息，分派给单个处理程序
> 2：多播：通知分派给多个处理程序

# 单播消息 #
> a.定义消息类型，继承MediatR.IRequest接口的消息类型
> IRequest<T> 单播消息有返回值，类型为T
> IRequest  无返回值单播消息 

``` 
public class Ping:IRequest<string>
{
    //可自定义字段
    public string Name {get;set;}

    public string Content {get;set;} 
}
```
> b.创建处理消息的类，继承IRequestHandler<Ping,string> Ping 要处理的消息类，string 处理完消息返回的类型
```
public class pingHandler:IRequestHandler<Ping,string>
{
    //实现IRequestHandler接口的Handler方法
    public Task<string> Handler(Ping request,CancellationToken cancellationToken)
    { 
        Console.info('Ping Dowen……',request.Name);
        return Task.FromResult("ok");
    }
}
```
> c.使用中介发送单播消息
```
//可以使用依赖注入的方式获得mediator
IMediator mediator = context.RequestServices.GetRequiredService<IMediator>();  
Ping ping = new Ping() { Title = "TestTitle" };
string result = await mediator.Send(ping);
await context.Response.WriteAsync(result);
```

# 多播消息 #
> a.定义多播消息类，继承INotification
```
public class Notification:INotification
{
    public string Message { get; set; } 
}
```
> b.定义一个或多个消息处理类
```
public class Noty1Handler : INotificationHandler<Notification>  
{
    public Task Handle(Notification notification, CancellationToken cancellationToken)
    {
        Console.WriteLine("Noty1Handler Doing..."+notification.Message);
        return Task.CompletedTask;
    }
}
```

```
 public class Noty2Handler : INotificationHandler<Notification>
    {
        public Task Handle(Notification notification, CancellationToken cancellationToken)
        {
            Console.WriteLine("Noty2Handler Doing..." + notification.Message);
            return Task.CompletedTask;
        }
    }
```
> c. 发布消息
```
IMediator mediator = context.RequestServices.GetRequiredService<IMediator>();
NotyPing notyPing = new NotyPing { Message = "Test Noty" };
await mediator.Publish(notyPing);
```

> d.多路广播发布策略问题
Publish 方法的默认实现：同步循环每个处理程序，一个失败不影响后边的处理程序，这样可以确保每个处理程序都依次运行，而且按照顺序运行。
根据发布通知的不同需求，您可能需要不同的策略来处理通知，也许您想并行发布所有通知，或者使用您自己的异常处理逻辑包装每个通知处理程序。
在 MediatR.Examples.PublishStrategies 中可以找到一些示例实现， 其实就是使用 PublishStrategy 枚举设置不同的策略，参考以下链接。

> 6.类型协变（单播处理器和多播处理器）
例如：您可以实现 INotificationHandler <INotification> 来处理所有通知

> 7.参考资料
MediatR 知多少  https://www.jianshu.com/p/583bcba352ec
MediatR Document WIKI  https://github.com/jbogard/MediatR/wiki
ASP.NET Core 使用 MediatR进 程内发布与订阅  https://www.cnblogs.com/guokun/p/11001052.html