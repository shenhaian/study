/*
*┌────────────────────────────────────────────────┐
*│　描   述：AbstactFactoryController                                                    
*│　作   者：sha                                              
*│　版   本：1.0                                              
*│　创建时间：2020/7/22 17:15:53                        
*└────────────────────────────────────────────────┘
*/
using Autofac;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesignModes._01Create._02AbstractFactory
{
    /// <summary>
    /// 抽象工厂模式：提供一系列相关或相互依赖对象的接口，而无需指定他们具体的类
    /// 在客户端根据不同的配置选择不同的工厂，例如根据配置的数据库类型的不同选择使用 Access 数据库仓储的工厂还是使用 SqlServer 数据库的仓储工厂
    /// </summary>
    [ApiController]
    [Route("api/AbstactFactory/[action]")]
    public class AbstactFactoryController : ControllerBase
    {
        /// <summary>
        /// 抽象工厂
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public string AbstractFactoryTest()
        {
            IDbFactory factory = new SqlServerFactory();
            IUserRepo userRepo = factory.CreateUserRepo();
            userRepo.Insert(null);
            userRepo.GetUser(1);

            factory = new AccessFactory();
            userRepo = factory.CreateUserRepo();
            userRepo.Insert(null);
            userRepo.GetUser(0);

            return "Ok";
        }

        /// <summary>
        /// 抽象工厂+反射
        /// </summary>
        /// <param name="dbName">SqlServer||Access</param>
        /// <returns></returns>
        [HttpGet]
        public string AbstractFactoryReflection(string dbName)
        {
            IUserRepo userRepo = DataAccess.CreateUserRepo(dbName);
            userRepo.Insert(null);
            IDepartmentRepo departmentRepo = DataAccess.CreateDepartmentRepo(dbName);
            departmentRepo.CreateDepartment(null);
            return "Ok Reflection";
        }

        /// <summary>
        /// 抽象工厂+依赖注入
        /// </summary>
        /// <param name="type"> 1 =SqlServer Other= Access</param>
        /// <returns></returns>
        [HttpGet]
        public string AbstractFactoryDependencyInjection(int type)
        {
            var builder = new ContainerBuilder();
            if (type == 1)
            {
                builder.RegisterType<SqlServerFactory>().As<IDbFactory>();
            }
            else
            {
                builder.RegisterType<AccessFactory>().As<IDbFactory>();
            }
            var container = builder.Build();
            var dbFactory = container.Resolve<IDbFactory>();
            IUserRepo userRepo = dbFactory.CreateUserRepo();
            userRepo.Insert(null);
            userRepo.GetUser(0);

            IDepartmentRepo departmentRepo = dbFactory.CreateDepartmentRepo();
            departmentRepo.CreateDepartment(null);

            return "Ok DependencyInjection";
        }
    }
}
