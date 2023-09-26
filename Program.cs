using System;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        { double s=0,x=0.1,i=1,m=0,y=0;
    const double p=3.14;
    while (x<=0.8 & Math.Pow (x,i)>=0.0001)
    {
        m=Math.Pow(x,i)*Math.Sin(x*p/4);
        s=s+m;
        y=x*Math.Sin(p/4)/(1 - 2*x*Math.Cos(p/4)*Math.Pow(x,2));
        i=i+ 1;
        x=x+ 0.1;
    }
        Console.WriteLine(s);
         Console.WriteLine(y);
        }
    }
}
