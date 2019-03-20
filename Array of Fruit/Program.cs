using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array_of_Fruit
{
    class Program
    {
        /// <summary>
        /// Fruit Array for Today
        /// </summary>
        public enum Fruit
        {
            none,
            apple,
            orange,
            banana,
            peach,
            grape,
            lemon
        }
        static void Main(string[] args)
        {
            Fruit[] fruits = new Fruit[3];
            string userResponse;

            for (int index = 0; index < fruits.Count(); index++)
            {
                Console.Write($"Fruit {index + 1}: ");
                userResponse = Console.ReadLine().ToLower();
                Enum.TryParse(userResponse, out fruits[index]);
            }

            Console.WriteLine();

            foreach (Fruit fruit in fruits)
            {
                Console.WriteLine(fruit);
            }

            Console.WriteLine("Press any key...");
            Console.ReadKey();
        }
    }
}
