/*
*┌────────────────────────────────────────────────┐
*│　描   述：简单工厂实现实例：    
*             简单工厂模式是由一个工厂对象决定创建出哪一种产品类的实例。
*             简单工厂模式是工厂模式家族中最简单实用的模式，但不属于23种GOF设计模式之一。
*             因为每次要新增类型的时候必须修改工厂内部代码，不符合开闭原则。在实际的业务代码里，简单工厂的应用还是蛮多的。
*│　作   者：sha                                              
*│　版   本：1.0                                              
*│　创建时间：2020/7/22 11:08:41                        
*└────────────────────────────────────────────────┘
*/
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace DesignModes._01Create._01SimpleFactory
{

    /// <summary>
    /// 父对象
    /// </summary>
    public class Operation
    {
        public double Number1 { get; set; }

        public double Number2 { get; set; }

        public virtual double GetResult()
        {
            return 0;
        }
    }

    /// <summary>
    /// 子对象 OperationAdd
    /// </summary>
    public class OperationAdd:Operation
    {
        public override double GetResult()
        {
            return Number1 + Number2;
        }
    }

    /// <summary>
    /// 子对象 OperationSub
    /// </summary>
    public class OperationSub : Operation
    {
        public override double GetResult()
        {
            return Number1 - Number2;
        }
    }

    /// <summary>
    /// 子对象 OperationMul
    /// </summary>
    public class OperationMul : Operation
    {
        public override double GetResult()
        {
            return Number1 * Number2;
        }
    }

    /// <summary>
    /// 子对象 OperationDiv
    /// </summary>
    public class OperationDiv : Operation
    {
        public override double GetResult()
        {
            if (Number2 == 0)
            {
                throw new Exception("除数不能为0");
            }
            return Number1 / Number2;
        }
    }

}
