using System;

namespace ACharacterCounter
{
    class Program
    {
        static void Main(string[] args)
        {
            //program palub kasutajal sisestada ees- ja perekonnanime;
            //programm kuvab mitu 'a' tähte on kasutaja ees- ja perekonnanimes kokku;

            Console.WriteLine("Sisesta oma eesnimi:");
            string firstName = Console.ReadLine();
            Console.WriteLine("Siseta oma perekonnanimi:");
            string lastName = Console.ReadLine();
            string fullName = $"{firstName}{lastName}".ToLower();
            Console.WriteLine(fullName);

            int aCaounter = 0;

            for (int i = 0; i < fullName.Length; i++)
            {
                if (fullName[i] == 'a')
                {
                    aCaounter++;
                }
            }
            if (aCaounter != 1)
            {
                Console.WriteLine($"Sinu nimes on {aCaounter} 'a' tähte.");
            }
            else
            {
                Console.WriteLine($"Sinu nimes on {aCaounter} 'a' täht.");
            }


        }
    }
}
