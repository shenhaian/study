﻿# 抽象工厂模式 AbstractFactory

## Intro 简介

> 抽象工厂模式，提供一系列相关或相互依赖对象的接口，而无需指定他们具体的类。

实现抽象工作模式所需要的组件，主要部分：

- 抽象工厂/抽象产品
- 具体工厂1/具体产品1
- 具体工厂2/具体产品2
- ...

在客户端根据不同的配置选择不同的工厂，例如根据配置的数据库类型的不同选择使用 Access 数据库仓储的工厂还是使用 SqlServer 数据库的仓储工厂

``` csharp
IDbFactory factory = new AccessFactory();
var userRepo = factory.CreateUserRepo();
userRepo.Insert(null);
var departmentRepo = factory.CreateDepartmentRepo();

factory = new SqlServerFactory();
userRepo = factory.CreateUserRepo();
userRepo.Insert(null);
```

## 工厂方法和抽象工厂的区别

工厂方法模式：定义一个用于创建对象的接口，让子类决定实例化哪一个类
抽象工厂模式：为创建一组相关或相互依赖的对象提供一个接口，而且无需指定他们的具体类
区别在于产品，如果产品单一，最合适用工厂模式，但是如果有多个业务品种、业务分类时，通过抽象工厂模式产生需要的对象是一种非常好的解决方式。再通俗深化理解下：工厂模式针对的是一个产品等级结构 ，抽象工厂模式针对的是面向多个产品等级结构的。

抽象工厂关键在于产品之间的抽象关系，所以一般至少要两个产品；工厂方法在于生成产品，不关注产品间的关系，所以可以只生成一个产品。

抽象工厂更像一个复杂版本的策略模式，策略模式通过更换策略来改变处理方式或者结果；而抽象工厂的客户端，通过更换工厂而改变结果。

工厂方法目的是生产产品，所以能看到产品，而且还要使用产品。当然，如果产品在创建者内部使用，那么工厂方法就是为了完善创建者，从而可以使用创建者。另外创建者本身是不能更换所生产产品的。

抽象工厂的工厂是类；工厂方法的工厂是方法。抽象工厂的工厂类就做一件事情生产产品。生产的产品给客户端使用，绝不给自己用。工厂方法生产产品，可以给系统用，可以给客户端用，也可以自己这个类使用。自己这个类除了这个工厂方法外，还可以有其他功能性的方法。
 



