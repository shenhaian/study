/*
*┌────────────────────────────────────────────────┐
*│　描   述：MediatRController                                                    
*│　作   者：sha                                              
*│　版   本：1.0                                              
*│　创建时间：2020/7/21 15:51:14                        
*└────────────────────────────────────────────────┘
*/
using MediatR;
using MediatRs.Notify;
using MediatRs.SingleCast;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using System.Threading.Tasks;

namespace MediatRs.Controllers
{
    [Controller]
    [Route("api/MediatR/[action]")] 
    public class MediatRController : ControllerBase
    {
        public IMediator _Mediator; 
        public MediatRController(IMediator mediator)
        {
            _Mediator = mediator;
        }

        /// <summary>
        /// 单播消息测试
        /// </summary> 
        /// <returns></returns> 
        [HttpGet]
        [Display(Description = "单播消息测试")] 
        public Task<string> SingleMessageTest()
        {
            var resut= _Mediator.Send(new SingleMessage() {Type="ChatMessage",Content="测试单播发送消息"});
            return resut;
        }

        /// <summary>
        /// 通知消息测试
        /// </summary> 
        /// <returns></returns> 
        [HttpGet]
        [Display(Description = "通知消息测试")]
        public Task<string> NotifyMessageTest()
        {
            _Mediator.Publish(new NotifyMessage() { Type = "NotifyMessage", Content = "测试通知发送消息" });
            return Task.FromResult("Ok");
        }
    }
}
