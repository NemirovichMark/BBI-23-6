using System.Runtime.ConstrainedExecution;

double x4 = 1.5;
double sum4 = 0.0;
double xPower = 1.0;
for (int i = 1; i <= 9; i++)
{
    double term = Math.Cos(i * x4) / xPower;
    sum4 += term;
    xPower *= x4;
}

Console.WriteLine(sum4);