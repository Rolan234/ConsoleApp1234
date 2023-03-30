using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    // <summary>
    // Создание списка целых чисел 
    // и основание методы работы с элементом списка
    // <summary>
    internal class Program
    {
        static void Main(string[] args)
        {
            // Создание пустой коллекций 
            List<int> ints=new List<int>();
            // Добавление  целых значений в коллекцию
            ints.Add(1);
            ints.Add(10);
            ints.Add(25);
            ints.Add(17);
            ints.Add(10);
            foreach (int elem in ints)
            {
                Console.Write($"{elem}\t");
            }
            Console.WriteLine();
            ints.Add(30);
            foreach (int elem in ints)
            {
                Console.Write($"{elem}\t");
            }
            // Вставка элемента по указанному индексу (cдвиг вправо)
            Console.WriteLine();
            ints.Insert(0, 500);
            foreach (int elem in ints)
            {
                Console.Write($"{elem}\t");
            }
            // Добавление в список одномерного массива
            Console.WriteLine();
            ints.AddRange(new[] {-5,0,14});
            foreach (int elem in ints)
            {
                Console.Write($"{elem}\t");
            }
            // Определение количества элементов коллекций
            Console.WriteLine();
            int size=ints.Count();
            //Console.WriteLine($"Текущее количество элементов = {size}");
            Console.WriteLine($"Текущее количество элементов = {ints.Count}");
            // Определение индекса элемента со значением 25
            Console.WriteLine();
            Console.WriteLine($"Индекс элемента со значением 25 = {ints.IndexOf(25)}");
            // Удаление из коллекций первого элемента со значения 10
            ints.Remove(10);
            foreach (int elem in ints)
            {
                Console.Write($"{elem}\t");
            }
            // Удаление из коллекций элемента с указанным индексом 
            Console.WriteLine();
            ints.RemoveAt(2);
            foreach (int elem in ints)
            {
                Console.Write($"{elem}\t");
            }
             // Сортировка коллекций по возрастанию 
             Console.WriteLine();
            ints.Sort();
            foreach (int elem in ints)
            {
                Console.Write($"{elem}\t");
            }
            // Сортировка коллекций по убыванию
            ints.Reverse();
            foreach (int elem in ints)
            {
                Console.Write($"{elem}\t");
            }

            Console.Read();

        }
    }
}
