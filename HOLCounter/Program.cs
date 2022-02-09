using System;

namespace HOLCounter
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm kuvab, mitu 'h' 'o' ja 'l' tähte on lauses "Hello World!"; 

            string message = "Hello World!".ToLower();
            //Console.WriteLine(message);

            int aCounterh = 0;
            int aCountero = 0;
            int aCounterl = 0;
            int sum = 0;
           
            for (int i = 0; i < message.Length; i++)
            {
                if (message[i] == 'h')
                {
                    aCounterh++;
                }
        
            }
            for (int i = 0; i < message.Length; i++)
            {
                if (message[i] == 'o')
                {
                    aCountero++;
                }

            }
            for (int i = 0; i < message.Length; i++)
            {
                if (message[i] == 'l')
                {
                    aCounterl++;
                }

            }

            if (aCounterh != 1)
            {
                Console.WriteLine($"Fraasis 'Hello World!' on {aCounterh} 'h' tähte.");
            }
            else
            {
                Console.WriteLine($"Fraasis 'Hello World!' on {aCounterh} 'h' täht.");
            }
            if (aCountero != 1)
            {
                Console.WriteLine($"Fraasis 'Hello World!' on {aCountero} 'o' tähte.");
            }
            else
            {
                Console.WriteLine($"Fraasis 'Hello World!' on {aCountero} 'o' täht.");
            }
            if (aCounterl != 1)
            {
                Console.WriteLine($"Fraasis 'Hello World!' on {aCounterl} 'l' tähte.");
            }
            else
            {
                Console.WriteLine($"Fraasis 'Hello World!' on {aCounterl} 'l' täht.");
            }
            sum = aCounterh + aCounterl + aCountero;
            Console.WriteLine($"Kokku on otsitavaid tähti {sum}.");
        }
    }
}
