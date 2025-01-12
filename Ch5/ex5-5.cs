﻿using System;
class BaseClass
{
    virtual public void MethodA()
    {
        Console.WriteLine("Base MethodA");
    }
    virtual public void MethodB()
    {
        Console.WriteLine("Base MethodB");
    }
    virtual public void MethodC()
    {
        Console.WriteLine("Base MethodC");
    }
}
class DerivedClass : BaseClass
{
    new public void MethodA()
    {
        Console.WriteLine("Derived MethodA");
    }
    override public void MethodB()
    {
        Console.WriteLine("Derived MethodB");
    }
    public void MethodC()
    {
        Console.WriteLine("Derived MethodC");
    }
}
class VirtualMethodApp
{
    public static void Main()
    {
        BaseClass s = new DerivedClass(); // 부모 클래스 참조 변수 = 파생클래스 객체
        s.MethodA(); // s 객체의 MathodA()가 호출 (new로 재정의 경우)
        s.MethodB(); // s가 가리키는 객체(파생클래스)의 MethodB()가 호출 (다형성)(override로 재정의)
        s.MethodC(); // s 객체의 MathodC()가 호출
    }
}