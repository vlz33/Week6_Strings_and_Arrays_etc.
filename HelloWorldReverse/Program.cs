using System;

namespace HelloWorldReverse
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm kuvab lause "Hello, World!" tagurpidi;

            string message = "Hello, World!";

            for (int i = message.Length - 1; i >= 0; i--)
            {
                Console.Write(message[i]);
            }
        }
    }
}
