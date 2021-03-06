﻿# 工厂方法 FactoryMethod

## Intro 简介

> 工厂方法模式（Factory Method）定义一个用于创建对象的接口，让子类决定实例化哪一个类。工厂方法使一个类的实例化延迟到子类。

## 特点

工厂方法模式实现时，客户端需要决定实例化哪一个工厂来实现客户端的操作，也会存在着选择判断的问题，不过和简单工厂相比，简单工厂的选择判断是在工厂内部，而工厂方法则将选择判断转移到了客户端。

## Sample

``` csharp
ILeifengFactory factory = new UndergraduteFactory();
var studentLeifeng = factory.CreateLeifeng();
studentLeifeng.BuyRice();

factory = new VolunteerFactory();
var leifeng1 = factory.CreateLeifeng();
leifeng1.Sweep();
``` 