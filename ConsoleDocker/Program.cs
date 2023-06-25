using System;

namespace ConsoleDocker
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i = 0;
            while(i < 1000)
            {
                Console.WriteLine("Naber " + i);
                i++;
                System.Threading.Thread.Sleep(1000);
            }
        }
    }
}
