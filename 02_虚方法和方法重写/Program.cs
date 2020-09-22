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

    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
