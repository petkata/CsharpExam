using System;

class explorer
{
    static void Main()
    {
        string line = Console.ReadLine();
        int n = int.Parse(line);

        for (int i = 0; i < n / 2; i++)
        {
            string tire = new string('-', n / 2 - i);
            string tire2 = new string('-', i);

            if (i == 0)
            {
                Console.WriteLine("{0}*{0}", tire);
            }
            else
            {
                string tire3 = new string('-', i - 1);
                Console.WriteLine("{0}*{1}{2}*{0}", tire, tire2, tire3);
            }
        }



        for (int i = n / 2; i >= 0 && i < n / 2 + 1; i--)
        {
            string tire = new string('-', n / 2 - i);
            string tire2 = new string('-', i);

            if (i == 0)
            {
                Console.WriteLine("{0}*{0}", tire);
            }
            else
            {
                string tire3 = new string('-', i - 1);
                Console.WriteLine("{0}*{1}{2}*{0}", tire, tire2, tire3);
            }
        }


    }
}