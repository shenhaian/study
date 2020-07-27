/*
*┌────────────────────────────────────────────────┐
*│　描   述：SingleMessage                                                    
*│　作   者：sha                                              
*│　版   本：1.0                                              
*│　创建时间：2020/7/21 15:44:55                        
*└────────────────────────────────────────────────┘
*/
using MediatR; 
using System;
using System.Collections.Generic;
using System.Text;

namespace MediatRs.SingleCast
{
    /// <summary>
    /// 单播消息体
    /// </summary>
   public class SingleMessage: IRequest<string>
    {
        public string Type { get; set; }

        public string Content { get; set; }
    }
}
