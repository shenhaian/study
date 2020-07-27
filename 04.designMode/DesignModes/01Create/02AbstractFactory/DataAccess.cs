/*
*┌────────────────────────────────────────────────┐
*│　描   述：DataAccess                                                    
*│　作   者：sha                                              
*│　版   本：1.0                                              
*│　创建时间：2020/7/22 11:46:28                        
*└────────────────────────────────────────────────┘
*/
using DesignModes.Hepler;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesignModes._01Create._02AbstractFactory
{
   public class DataAccess
    {
        public static readonly string AssemblyName = "DesignModes._01Create._02AbstractFactory"; 

        public static IUserRepo CreateUserRepo(string dbName)
        {
            return (IUserRepo)typeof(DataAccess).Assembly.CreateInstance($"{AssemblyName}.{dbName}UserRepo");
        }

        public static IDepartmentRepo CreateDepartmentRepo(string dbName)
        {
            return (IDepartmentRepo)typeof(DataAccess).Assembly.CreateInstance($"{AssemblyName}.{dbName}DepartmentRepo");
        }
    }
}
