using System; 

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {

#region уровень 3 задача 2
             double s=0,x=0.1,i=1,m=0,y=0;
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
#endregion уровень 3 задача 2
        }

 #region уровень 1 задача 5
            int p = 1; 
        	int sum = 0; 
        	for (int h = 0;h<=9;h++) 
        	{ 
            	int ph = p + h; 
            	sum = (int)(sum + Math.Pow(ph, 2)); 
        	} 
        	Console.WriteLine(sum);    	 
 #endregion уровень 1 задача 5
    

 #region уровень 1 задача 4
            double sum = 0; 
        	int x = 10; 
        	for (int i = 0;i <= 8; i += 1) 
        	{ 
            	sum += Math.Cos((i + 1) * x) / Math.Pow(x, 0); 
        	} 
        	Console.WriteLine(sum); 
           
#endregion уровень 1 задача 4


 #region уровень 1 задача 3
        	double sum = 0; 
        	for (double i = 1; i <= 113;i+=2) 
        	{ 
            	sum += (i + 1) / (i + 2); 
        	} 
        	Console.WriteLine(sum);
#endregion уровень 1 задача 3


#region уровень 1 задача 2
        	double sum = 0; 
        	for (double i = 1; i <= 10; i += 1) 
            {
            	sum = sum + (1 / i); 
            }
        	Console.WriteLine(sum); 
#endregion уровень 1 задача 2

#region уровень 1 задача 6
            double number = 0; 
        	for (double i = -4; i <= 4; i += 0.5) 
        	{ 
            	number = (Math.Pow(0.5 * i, 2) - 7 * i); 
            	Console.WriteLine($"{number} {i}"); 
            }
#endregion уровень 1 задача 6




}
}


