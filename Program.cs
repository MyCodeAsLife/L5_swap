using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L5_swap
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string userFirstName = "Петров";
            string userLastName = "Петр";

            Console.WriteLine($"Имя: {userFirstName}. Фамилия: {userLastName}.");
            Console.WriteLine(new string('-', 40)); //Для красоты

            // Вариан 1 по проще
            string tempString = userFirstName;
            userFirstName = userLastName;
            userLastName = tempString;
            
            // Вариант 2 чуть более правильный
            // P.S. Увы встроеной функции\метода подобной я несмог найти
            // Поэтому предстовляю вашему вниманию свой ААААААААААААВТОМОБИЛЬ!! *гхм тоесть велосипед
            //SwapString(ref userFirstName, ref userLastName);

            Console.WriteLine($"Имя: {userFirstName}. Фамилия: {userLastName}.");
            Console.WriteLine(new string('-', 40)); // Для красоты
        }

        static void SwapString(ref string firstValue, ref string secondValue)
        {
            string tempValue = firstValue;
            firstValue = secondValue;
            secondValue = tempValue;
        }
    }
}
