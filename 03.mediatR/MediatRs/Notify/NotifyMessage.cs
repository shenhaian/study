/*
*┌────────────────────────────────────────────────┐
*│　描   述：NotifyMessage                                                    
*│　作   者：sha                                              
*│　版   本：1.0                                              
*│　创建时间：2020/7/21 15:33:44                        
*└────────────────────────────────────────────────┘
*/
using MediatR;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace MediatRs.Notify
{
    /// <summary>
    /// 通知消息对象
    /// </summary>
   public class NotifyMessage:INotification
    {
        /// <summary>
        /// 消息类型
        /// </summary>
        public string Type { get; set; }

        /// <summary>
        /// 消息内容
        /// </summary>
        public string Content { get; set; }
    }
}
