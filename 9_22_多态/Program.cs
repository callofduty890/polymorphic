using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9_22_多态
{
    class SuperClass1   //基类1 默认 继承object
    {
        public string name, sex;
    }

    class SuperClass11 : SuperClass1 //继承
    {
        public int age;
    } //派生类 继承与SuperClass1

    class SubClass12 : SuperClass1 //派生类 继承与SuperClass1
    {
        public int age;
        public SubClass12()//默认构造函数
        {
            Console.WriteLine("调用构造函数SubClass12()...");
        }
    } //派生类 继承与SuperClass1

    class SubClass13 : SuperClass1 //派生类
    {
        public int age;
        public SubClass13(int age)//默认构造函数
        {
            Console.WriteLine("调用构造函数SubClass13()...");
        }
    } //派生类 继承与SuperClass1

    //===============================================

    class SuperClass2//基类有参构造函数
    {
        public string name; public string sex;
        public SuperClass2(string name, string sex)
        {
            this.name=name;this.sex = sex;
            Console.WriteLine("调用构造函数SuperClass2(string name, string sex)...");
        }
    }

    //派生类SubClass21 编译错误，没有满足基类构造函数
    //class SubClass21 : SuperClass2
    //{

    //}
    //class SubClass22 : SuperClass2
    //{
    //    public int age;
    //    //public SubClass22()//编译错误
    //    //{
    //    //    //默认构造函数，自动调用基类，但是无法满足基类的要求(两个输入参数)
    //    //}
    //}

    class SubClass23 : SuperClass2//派生类
    {
        public int age;
        public SubClass23(string name,string sex,int age) : base(name,sex)
        {
            this.age = age;
            Console.WriteLine("调用SubClass23的构造函数 SubClass23(string name,string sex,int age) : base(name,sex)");
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            //调用默认的构造函数
            SubClass12 obj12 = new SubClass12();
            //调用有参的购置函数
            SubClass23 objsubClass = new SubClass23("教练", "男", 18);
            Console.ReadKey();


        }
    }
}
