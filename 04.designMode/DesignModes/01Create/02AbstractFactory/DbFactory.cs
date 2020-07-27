/*
*┌────────────────────────────────────────────────┐
*│　描   述：DbFactory                                                    
*│　作   者：sha                                              
*│　版   本：1.0                                              
*│　创建时间：2020/7/22 16:58:14                        
*└────────────────────────────────────────────────┘
*/
using System;
using System.Collections.Generic;
using System.Text;

namespace DesignModes._01Create._02AbstractFactory
{
   public interface IDbFactory
    {
        IUserRepo CreateUserRepo();

        IDepartmentRepo CreateDepartmentRepo();
    }

    internal class SqlServerFactory : IDbFactory
    {
        public IDepartmentRepo CreateDepartmentRepo()
        {
            return new SqlServerDepartmentRepo();
        }

        public IUserRepo CreateUserRepo()
        {
            return new SqlServerUserRepo();
        }
    }

    internal class AccessFactory : IDbFactory
    {
        public IDepartmentRepo CreateDepartmentRepo()
        {
            return new AccessDepartmentRepo();
        }

        public IUserRepo CreateUserRepo()
        {
            return new AccessUserRepo();
        }
    }
}
