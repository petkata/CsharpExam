using System;

class WorkHours
{
    static void Main()
    {
        double h = double.Parse(Console.ReadLine());
        double d = double.Parse(Console.ReadLine());
        double p =double.Parse(Console.ReadLine());
        double realwork =(d - d * 0.1)*12;
        
        double efficientwh = realwork*p/100;
        int pyi = (int)Math.Floor(efficientwh);
        double diff = pyi - h;
        
        if (diff>=0)
        {
            Console.WriteLine("Yes");
        }
        else
        {
            Console.WriteLine("No");
        }
        Console.WriteLine(diff);
    }
}