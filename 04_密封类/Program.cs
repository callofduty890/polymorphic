using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_密封类
{
    class Parent
    {
        public virtual void MethodF()
        {
            Console.WriteLine("调用Parent的MethodF()");
        }
        public virtual void MethodG()
        {
            Console.WriteLine("调用Parent的MethodG()");
        }
    }

    class Child : Parent
    {
        public sealed override void MethodF() //密封方法
        {
            Console.WriteLine("调用Child的MethodF()");
        }

        public override void MethodG() //重写从基类继承的方法
        {
            Console.WriteLine("调用Child的MethodG()");
        }
    }

    sealed class Final : Child //密封类
    {
        //public override void MethodF() { };//编译错误

        public override void MethodG()//重写基类继承的方法
        {
            Console.WriteLine("调用Final的MethodG()");
        }
    }

    //sealed class Final1:Final  无法从密封类中派生

    class Program
    {
        static void Main(string[] args)
        {
            Final obj = new Final();
            obj.MethodF();
            obj.MethodG();
            Console.ReadKey();

        }
    }
}
