using System;


namespace class1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try 
            {
                // Number 1, 2
                Tel tel = new Tel();
                do
                {
                    Console.Write("День разговора (1 - 7): ");
                    tel.day = Convert.ToInt32(Console.ReadLine());
                    
                    if (tel.day > 7 || tel.day < 1) Console.WriteLine("Повторите ввод дня...");
                    
                } while (tel.day > 7 || tel.day < 1);
                Console.Write("Время разговора: ");
                tel.time = Convert.ToDouble(Console.ReadLine());
                
                Console.Write("Стоимость: ");
                tel.cost = Convert.ToDouble(Console.ReadLine());
                
                Console.WriteLine($"Итоговая стоимость: {tel.GetSum()}");
                //

                // Number 3
                SquareCycle cycle = new SquareCycle();
                cycle.Repeat();
                //
            }
            catch (Exception ex) 
            {
                Console.WriteLine(ex);
            }
            

            Console.ReadKey();
        }
    }
}