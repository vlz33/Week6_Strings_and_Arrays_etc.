using System;

namespace FirstOrLast
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm palub kasutajal sisestada ees- ja perekonnanime;
            //programm kontrollib andmete pikkust eraldi;
            //programm kuvab kumb neist on pikem;

            Console.WriteLine("Sisesta oma eesnimi");
            string firstName = Console.ReadLine();
            Console.WriteLine("Sisesta oma perekonnanimi");
            string lastName = Console.ReadLine();
            int firstNameLength = firstName.Length;
            int lastNameLength = lastName.Length;
            Console.WriteLine($"Sinu eesnimes on {firstNameLength} sümbolit.");
            Console.WriteLine($"Sinu perekonnanimes on {lastNameLength} sümbolit.");

            if (firstNameLength < lastNameLength)
            {
                Console.WriteLine("Sinu perekonnanimi on pikem kui eesnimi.");
            }
            else if (firstNameLength > lastNameLength)
            {
                Console.WriteLine("Sinu eesnimi on pikem kui perekonnanimi.");
            }
            else
            {
                Console.WriteLine("Sinu ees- ja perekonnanmes on võrdne arv sümboleid.");
            }
        }
    }
}
