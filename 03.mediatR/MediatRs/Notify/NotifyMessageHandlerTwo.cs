/*
*┌────────────────────────────────────────────────┐
*│　描   述：NotifyMessageHandlerTwo                                                    
*│　作   者：sha                                              
*│　版   本：1.0                                              
*│　创建时间：2020/7/21 15:41:42                        
*└────────────────────────────────────────────────┘
*/
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MediatRs.Notify
{
    public class NotifyMessageHandlerTwo : INotificationHandler<NotifyMessage>
    {
        public Task Handle(NotifyMessage notification, CancellationToken cancellationToken)
        {
            string type = this.GetType().FullName;
            Console.WriteLine($"执行者：{type}，消息类型：{notification.Type}，消息内容：{notification.Content}");
            return Task.CompletedTask;
        }
    }
}
