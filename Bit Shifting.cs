using System;

class bit
{
    static void Main()
    {
        ulong diff = ulong.Parse(Console.ReadLine());
        int numOfS = int.Parse(Console.ReadLine());
        ulong[] sieves = new ulong[numOfS];
        for (int i = 0; i < sieves.Length; i++)
        {
            sieves[i] = ulong.Parse(Console.ReadLine());
        }
        ulong res = diff & ~(sieves[0]);
        for (int i = 1; i < sieves.Length; i++)
        {
            res = res & ~(sieves[i]);
        }

        ulong count = 0;
        while (res != 0)
        {
            count++;
            res &= res - 1;
        }
        Console.WriteLine(count);
    }
}