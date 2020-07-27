# 建造者模式 Builder

## Intro 简介

> 建造者模式: 建造者模式隐藏了复杂对象的创建过程，它把复杂对象的创建过程加以抽象，通过子类继承或者重载的方式，动态的创建具有复合属性的对象。

需要的组件：

- Product
- AbstractBuilder 创建一个 Product 的抽象 builder
- ConcreteBuilder1/ConcreteBuilder2 创建 Product 具体的 builder
- Director 指挥 builder 如何创建一个复杂的 Product

## Sample

``` csharp
var director = new Director();
Builder builder1 = new ConcreteBuilder1(), builder2 = new ConcreteBuilder2();

director.Construct(builder1);
director.Construct(builder2);

var product2 = builder1.GetResult();
var product2 = builder2.GetResult();
```

.net core 中的各种 builder (`HostBuilder`/`ConfigurationBuilder`/...) 我觉得也是属于建造者模式的，只是 Builder 本身就是 Director，
通过 builder 来实现对象的各种参数配置构建最后的 Product (`Host`/`Configuration`/...)

## 总结
> 通过抽象产品的共同属性和方法形成一个抽象的产品基类，通过子类的继承或者重载，去实现产品的具体属性和方法。通过调用基类的抽象方法去实现 子类的组装。
> 直接操作基类的抽象方法去实现不同的子类的多样化实现
 