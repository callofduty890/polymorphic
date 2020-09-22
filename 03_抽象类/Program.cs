using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_抽象类
{
    abstract class Animal //基类Animal : 抽象类
    {
        public string name;
        public abstract void SayHi();
        public Animal(string name) { this.name = name; }//构造函数
    }

    class Dog:Animal      //派生类Dog
    {
        public override void SayHi()//重写SayHi
        {
            Console.WriteLine(this.name + "Wow Wow!");
        }
        public Dog(string name) : base(name) { } //构造函数
    }

    class Cat:Animal
    {
        public override void SayHi()//重写SayHi
        {
            Console.WriteLine(this.name + "Mew Mew!");
        }
       
        public Cat(string name) : base(name) { } //构造函数
    }

    //class Horse : Animal { } //编译错误 非抽象Horse继承了抽象类Animal但是，并未实现抽象方法
    abstract class Fish : Animal //编辑OK ，抽象类Fish继承了抽象类Animal但是并未实现抽象方法
    {
        public Fish(string name) : base(name) { } //构造函数
    }

    class Program
    {
        static void Main(string[] args)
        {
            //Animal an = new Animal(); //编译错误，抽象类不能实例化
            Animal[] animals = { new Dog("小白"), new Cat("小花") };

            foreach (Animal item in animals) item.SayHi();

            Console.ReadKey();
        }
    }
}
