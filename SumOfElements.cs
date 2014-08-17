using System;
using System.Linq;
class WorkHours
{
    static void Main()
    {
        string input = Console.ReadLine();
        double[] numbers = Array.ConvertAll<string, double>(input.Split(' '), double.Parse);
        double sumAll = 0;
        double maxValue = numbers.Max();
        foreach (var number in numbers)
        {
            sumAll += number;
        }
     //   Console.WriteLine(maxValue);
        if (sumAll / maxValue == 2 || maxValue==0)
        {
            Console.WriteLine("Yes, sum={0}",maxValue);
        }
        else
        {
            Console.WriteLine("No, diff={0}",Math.Abs((maxValue-(sumAll-maxValue))));
        }

    }
}