/*
*┌────────────────────────────────────────────────┐
*│　描   述：ComplexResume                                                    
*│　作   者：sha                                              
*│　版   本：1.0                                              
*│　创建时间：2020/7/23 14:31:34                        
*└────────────────────────────────────────────────┘
*/
using System;
using System.Collections.Generic;
using System.Text;

namespace DesignModes._01Create._05Prototype
{
    internal class WorkExperience:ICloneable
    { 
        public string TimePeriod { get; set; }

        public string Company { get; set; }

        public object Clone() => MemberwiseClone();
    }

    internal class ComplexResume : ICloneable
    {
        private WorkExperience _workExperiense;
        private string _name;
        private string _email;

        public ComplexResume() => _workExperiense = new WorkExperience();

        public ComplexResume(WorkExperience workExperience) => _workExperiense = (WorkExperience)workExperience.Clone();

        public void SetPersonalInfo(string name, string email)
        {
            this._name = name;
            this._email = email;
        }

        public void SetWorkExperience(string timePeriod, string company)
        {
            this._workExperiense.TimePeriod = timePeriod;
            this._workExperiense.Company = company;
        }

        public void Display()
        {
            Console.WriteLine($"UserInfo:{this._name},Email:{this._email}");
            Console.WriteLine($"WorExperience:{this._workExperiense.Company},Time:{this._workExperiense.TimePeriod}");
        }

        public object ShallowCopy() => MemberwiseClone();
        public object Clone() => new ComplexResume(_workExperiense) { _name = _name, _email = _email };
    }
}
