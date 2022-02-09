using System;

namespace DontPanic
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm asendab lauses  "Don't Panic" kõik 'o' tähed nulliga (0);
            //programm asendab kõik 'a' tähed neljaga (4);

            string message = "Don't Panic";
            message = message.Replace('o', '0');
            message = message.Replace('a', '4');

            Console.WriteLine(message);
        }
    }
}
