/*
*┌────────────────────────────────────────────────┐
*│　描   述：SimpleResume                                                    
*│　作   者：sha                                              
*│　版   本：1.0                                              
*│　创建时间：2020/7/23 14:23:31                        
*└────────────────────────────────────────────────┘
*/
using System;
using System.Collections.Generic;
using System.Text;

namespace DesignModes._01Create._05Prototype
{
    internal class SimpleResume : ICloneable
    {
        private string _name;
        private string _email;

        private string _timePeriod;
        private string _company;

        public void SetPersonalInfo(string name, string email)
        {
            this._name = name;
            this._email = email;
        }

        public void SetWorkExperience(string timePeriod, string company)
        {
            this._timePeriod = timePeriod;
            this._company = company;
        }

        public void Display()
        {
            Console.WriteLine($"UserInfo:{_name},Email:{_email}");
            Console.WriteLine($"WorkExperience:{_company},Time:{_timePeriod}");
        }


        public object Clone() => MemberwiseClone();
    }
}
