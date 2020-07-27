/*
*┌────────────────────────────────────────────────┐
*│　描   述：SingleMessageHandler                                                    
*│　作   者：sha                                              
*│　版   本：1.0                                              
*│　创建时间：2020/7/21 15:46:59                        
*└────────────────────────────────────────────────┘
*/
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MediatRs.SingleCast
{
    /// <summary>
    /// 单播消息处理
    /// </summary>
    public class SingleMessageHandler : IRequestHandler<SingleMessage, string>
    {
        /// <summary>
        /// 消息处理者
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public Task<string> Handle(SingleMessage request, CancellationToken cancellationToken)
        {
            var type = this.GetType().FullName;
            return Task.FromResult($"执行者:{type},消息类型：{request.Type}，消息内容：{request.Content}");
        }
    }
}
