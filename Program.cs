using System;
using static System.Console;
using System.Threading;
using Restaurant.Domain;
using System.Collections.Generic;

namespace Restaurant
{
    class Program
    {
        private static object orederQueue;

        static void Main(string[] args)
        {
            
            bool shouldNotExit = true;

            while (shouldNotExit)
            {
                WriteLine("1. Add order");
                WriteLine("2. List orders");
                WriteLine("3. Exit");

                ConsoleKeyInfo keyPressed = ReadKey(true);

                Clear();

                switch (keyPressed.Key)
                {
                    case ConsoleKey.D1:
                       
                        Write("Dish: ");
                        string dish = ReadLine();

                        Write("Table: ");
                        string table = ReadLine();
                        Order order = new Order(dish,table);

                        orderQueue.Enqueue(order);
                        Clear();
                        WriteLine("order registered");
                        Thread.Sleep(2000);

                        break;
                    case ConsoleKey.NumPad1:

                        break;

                    case ConsoleKey.D3:
                    case ConsoleKey.NumPad3:

                        shouldNotExit = false;

                        break;
                }

                Clear();
            }
        }
    }
  
}
