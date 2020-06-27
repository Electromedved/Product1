using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Product
{
    class Program
    {
        static void Main(string[] args)
        {

            string name;
            float quantity;
            string units;
            float price;

            Console.WriteLine("Название продукта:"); name = Console.ReadLine().Trim().ToUpper();
            Console.WriteLine("Количество продукта:"); quantity = float.Parse(Console.ReadLine().Replace(",", "."));
            Console.WriteLine("Единицы измерения:"); units = Console.ReadLine().Trim().ToLower();
            Console.WriteLine("Цена продукта:"); price = float.Parse(Console.ReadLine().Replace(",", "."));

            Console.Clear();

            Console.WriteLine($"Название продукта: {name}");
            Console.WriteLine($"Количество продукта: {quantity}");
            Console.WriteLine($"Единицы измерения: {units}");
            Console.WriteLine($"Цена продукта: {price}");

            Console.ReadLine();
        }
    }
}
