﻿# 原型模式 Prototype

## Intro 简介

> 原型模式，用原型实例指定创建对象的种类，并且通过拷贝这些原型创建新的对象

原型模式其实就是从一个对象再创建另外一个可定制的对象而且不需要知道任何创建的细节。

## 实现方式

实现方式大致如下：

在 c# 中可以实现 `ICloneable` 接口和 `MemberwiseClone` 方法来方便的实现原型模式

``` csharp
// 浅复制
public object Clone() => MemberwiseClone();
``` 