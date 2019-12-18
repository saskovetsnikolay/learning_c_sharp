using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
            * Exceptions
            * Arrays and Lists
            * Decimal to Binary
            * Formatting string
            * Binary to Decimal
            */

/*
 * Создать программу которая будет считывать с консоли число
 * Если число меньше нуля или дробное кидать ошибку с текстом "Not Right Number Format"
 * Иначе будет создавать массив с двоичным представлением числа, выводить число (в двоичном виде)
 * в консоль видом: Binary number: 010101
 * А после будет удалять из массива все нули и выводить в консоль видом: Binary number: 111
 * А потом выводить "Decimal from only ones : 7" *********
 */

namespace from_decimal_to_binary
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers;
            int number = Convert.ToInt32(Console.ReadLine());
            float c = (float)number;
            //string b = Convert.ToString(number, 2);
            int a = 0;
            int i = 0;
            numbers = new int[32];
            while (number >= 1)
            {
                a = number % 2;
                numbers[i] = a;
                i++;
                number = number / 2;
                Console.WriteLine(a);
            }
                //Console.WriteLine(b);
                if (a == 0 & a == c)
            {
                Console.WriteLine("Number format isn\'t right.");
            }
           

        }
    }
}
/*int item = Convert.ToInt32(b);
numbers = new int[item];
            Console.WriteLine(numbers);*/