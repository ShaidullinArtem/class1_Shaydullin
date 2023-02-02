using System;

namespace class1
{
    public class SquareCycle
    {   
        public void Repeat()
        {
            int square;
            for (int i = 1; i < 10; i++)
            {
                square = (int)Math.Pow(i, 2);
                Console.WriteLine(i);
                StopCycle pr = new StopCycle();
                pr.Print(square);
            }
        }
    }
}