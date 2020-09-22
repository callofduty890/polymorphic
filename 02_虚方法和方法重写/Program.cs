using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_虚方法和方法重写
{
    public class Dimension//基类
    {
        protected double x, y;
        public Dimension() { }//默认构造函数

        public Dimension(double x, double y)
        {
            this.x = x;this.y = y;
        }//两个有参的构造函数

        public virtual double Area()
        {
            return this.x * this.y;
        }
    }

    public class Circle : Dimension//派生类：圆
    {
        public Circle(double r) : base(r, 0) { }
        public override double Area()//圆的面积
        {
            return Math.PI * x * x;
        }
    }

    public class Shere : Dimension //派生类：球体
    {
        public Shere(double r) : base(r, 0) { }
        public override double Area()//球体的表面积
        {
            return 4 * Math.PI * x * x;
        }
    }

    public class Cylinder : Dimension //派生类:圆柱体
    {
        public Cylinder(double r,double h) : base(r, h) { }
        public override double Area()//圆柱表面积
        {
            return 2*Math.PI*x*x+2*Math.PI*x*y;
        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            double r = 3.0, h = 5.0;
            Dimension[] dimensions = { new Circle(r), new Shere(r), new Cylinder(r, h) };

            foreach (Dimension item in dimensions)
            {
                //显示不同类型状态的表面积
                Console.WriteLine("Area of {0}={1:0.00}", item.GetType(), item.Area());
            }

            Console.ReadKey();
        }
    }
}
