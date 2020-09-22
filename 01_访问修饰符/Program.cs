using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_访问修饰符
{
    public class ClassA
    {
        protected double x_protected;//受保护的字段
        private double y_private;//私有字段

        public void setY(double y)//公共方法
        {
            this.y_private = y;
        }

        public double getY()//公共方法
        {
            return this.y_private;
        }

        public ClassA(double x, double y)
        {
            this.y_private = y;
        }
             
    }

    public class ClassB:ClassA
    {
        public double z_public;//公共实例字段

        public void print()    //公共实例方法
        {
            //OK，可访问基类的Protected成员
            Console.WriteLine(this.x_protected);
            //NO  不可访问私有字段
            //Console.WriteLine(this.y_private);
            //OK 可以访问公有方法(公有方法当中访问私有字段)
            Console.WriteLine(this.getY());
            //OK 可以访问公有的字段
            Console.WriteLine(this.z_public);
        }

        public ClassB(double x, double y, double z):base(x,y)//调用带3个参数的构造函数,调基类
        {
            this.z_public = z;
        }

    }

    class Program
    {
        static void Main(string[] args)
        {

            //派生类
            ClassB objclassb = new ClassB(1.0, 2.0, 3.0);

            //设置->访问修饰值
            objclassb.setY(2.2);
            objclassb.z_public = 3.3;
            //访问方法
            objclassb.print();//访问类的成员Print()
            Console.ReadKey();


        }
    }
}
