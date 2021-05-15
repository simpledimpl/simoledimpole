using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            bool k = false; //переменная показывающая, что введённая последовательность возрастающая
            Console.WriteLine("Введите колличество цифр в массиве"); //Выводим текст в консоль
            int n = int.Parse(Console.ReadLine()); //Считываем цифры с консоли и записываем в переменную n
            int[] mass = new int[n]; //Создаём массив чисел размера N

            for (int i = 0; i < n; i++) //Проходимся по массиву цифр
                mass[i] = int.Parse(Console.ReadLine());//и в каждую ячейку массива записываем новое значение считанное с консоли

            for (int i = 0; i < n - 1; i++) //делаем тоже самое только для возрастающей последовательности
                if (mass[i] < mass[i + 1]) k = true;
                else
                {
                    k = false;
                    break;
                }


            if (k) //если же первое условие не сработало - проверил может последовательность возрастающая?
                Console.WriteLine("Данная последовательность - возрастающая");//если да тогда выведем текст что ниже
            else // в остальных случаях последовательность не возрастающая
                Console.WriteLine("Данная последовательность - не возрастающая");
            Console.ReadKey();
        }
    }
}