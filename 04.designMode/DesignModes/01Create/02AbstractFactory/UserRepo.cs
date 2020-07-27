/*
*┌────────────────────────────────────────────────┐
*│　描   述：IUserRepo                                                    
*│　作   者：sha                                              
*│　版   本：1.0                                              
*│　创建时间：2020/7/22 11:50:36                        
*└────────────────────────────────────────────────┘
*/
using System;
using System.Collections.Generic;
using System.Text;

namespace DesignModes._01Create._02AbstractFactory
{
    public interface IUserRepo
    {
        void Insert(User user);

        User GetUser(int userid);
    }

    internal class SqlServerUserRepo : IUserRepo
    {
        private string type = typeof(SqlServerUserRepo).FullName;
        public User GetUser(int userid)
        { 
            Console.WriteLine($"执行对象：{type}，方法名称：GetUser()");
            return null;
        }

        public void Insert(User user)
        {
            Console.WriteLine($"执行对象：{type}，方法名称：Insert()"); 
        }
    }

    internal class AccessUserRepo : IUserRepo
    {
        private string type = typeof(AccessUserRepo).FullName;
        public User GetUser(int userid)
        {
            Console.WriteLine($"执行对象：{type}，方法名称：GetUser()");
            return null;
        }

        public void Insert(User user)
        {
            Console.WriteLine($"执行对象：{type}，方法名称：Insert()");
        }
    }
}
