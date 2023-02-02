using System;

namespace class1
{
    public class StopCycle
    {
        public void Print(int arg)
        {
            if (arg > 25) 
            {
                Console.WriteLine("Квадрат числа больше 25!");
                Console.ReadKey();
                Environment.Exit(0);
            }
                
        }
    }
}