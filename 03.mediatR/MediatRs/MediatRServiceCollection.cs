/*
*┌────────────────────────────────────────────────┐
*│　描   述：MediatRExtension                                                    
*│　作   者：sha                                              
*│　版   本：1.0                                              
*│　创建时间：2020/7/21 15:58:50                        
*└────────────────────────────────────────────────┘
*/
using MediatR;
using MediatRs.Notify;
using MediatRs.SingleCast;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace MediatRs
{
    /// <summary>
    /// 添加服务
    /// </summary>
    public static class MediatRServiceCollection
    {
        public static IServiceCollection AddMediatRService(this IServiceCollection services)
        {
            if (services == null)
            {
                throw new ArgumentNullException(nameof(services));
            }
            Assembly[] assemblies = new Assembly[] { 
                    typeof(NotifyMessageHandlerTwo).Assembly
            };
            services.AddMediatR(assemblies); 
            return services;
        }
    }
}
