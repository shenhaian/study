/*
*┌────────────────────────────────────────────────┐
*│　描   述：OperationFactory                                                    
*│　作   者：sha                                              
*│　版   本：1.0                                              
*│　创建时间：2020/7/22 11:17:21                        
*└────────────────────────────────────────────────┘
*/
using System;
using System.Collections.Generic;
using System.Text;

namespace DesignModes._01Create._01SimpleFactory
{
    /// <summary>
    /// 对象工厂
    /// </summary>
   public class OperationFactory
    {
        public static Operation CreateOperation(string operate)
        {
            Operation operation = null;
            switch (operate)
            {
                case "+":
                    operation = new OperationAdd();
                    break;

                case "-":
                    operation = new OperationSub();
                    break;

                case "*":
                    operation = new OperationMul();
                    break;

                case "/":
                    operation = new OperationDiv();
                    break;
                default:
                    throw new Exception("此操作类型不存在");
            }
            return operation;
        }
    }
}
