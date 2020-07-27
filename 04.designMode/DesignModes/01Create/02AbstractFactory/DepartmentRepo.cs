/*
*┌────────────────────────────────────────────────┐
*│　描   述：IDepartmentRepo                                                    
*│　作   者：sha                                              
*│　版   本：1.0                                              
*│　创建时间：2020/7/22 11:50:53                        
*└────────────────────────────────────────────────┘
*/
using System;
using System.Collections.Generic;
using System.Text;

namespace DesignModes._01Create._02AbstractFactory
{
    public interface IDepartmentRepo
    {
        void CreateDepartment(Department department);
    }

    internal class SqlServerDepartmentRepo : IDepartmentRepo
    {
        private string type = typeof(SqlServerDepartmentRepo).FullName;
        public void CreateDepartment(Department department)
        {
            Console.WriteLine($"执行对象：{type}，方法名称：CreateDepartment()");
        }
    }

    internal class AccessDepartmentRepo : IDepartmentRepo
    {
        private string type = typeof(AccessDepartmentRepo).FullName;
        public void CreateDepartment(Department department)
        {
            Console.WriteLine($"执行对象：{type}，方法名称：CreateDepartment()");
        }
    }

}
