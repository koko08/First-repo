using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Напишете програма, която въвежда във масив необходими продукти за торта разделени с ,
            Console.WriteLine("Enter the products needed for the cake: ");
            string[] products = Console.ReadLine().Split(',').ToArray();
            //Въвежда низ начина на приготвяне
            Console.WriteLine("Enter the receipt: ");
            string receipt = Console.ReadLine();
            //Извежда на екрана с главни букви "НЕОБХОДИМИ ПРОДУКТИ ЗА ТОРТА "ГАРАЖ"" един под друг
            Console.WriteLine("PRODUCTS NEEDED FOR THE CAKE 'ГАРАЖ'");
            for (int i = 0; i < products.Length; i++)
            {
                Console.WriteLine("*" + products[i]);
            }
            //Извежда "Начин на приготвяне" като всяко изречение е на нов ред.
            Console.WriteLine("The way to cook: " + receipt);
            //Ако в продуктите има бадеми, да се заменят с орехи
            int k = 0;
            for (int i = 0; i < products.Length; i++)
            {
                if (products[i] == "Almond")
                {
                    k = i;
                    products[k] = "Walnut";
                }
            }
            //Да се разпечата втори вариант на рецептата
        }
    }
}
