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
            string tempString = userFirstName;

            Console.WriteLine($"Имя: {userFirstName}. Фамилия: {userLastName}.\n");

            userFirstName = userLastName;
            userLastName = tempString;

            Console.WriteLine($"Имя: {userFirstName}. Фамилия: {userLastName}.\n");
        }
    }
}
