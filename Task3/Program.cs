using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    /*
    Використовуючи Visual Studio, створіть проект за шаблоном Console Application. 
    Створіть колекцію MyDictionary. Реалізуйте у найпростішому наближенні можливість використання її екземпляра 
    аналогічно екземпляру класу Dictionary. Мінімально необхідний інтерфейс взаємодії з екземпляром повинен включати 
    метод додавання елемента, індексатор для отримання значення елемента за вказаним індексом 
    і властивість тільки для читання для отримання загальної кількості елементів. 
    Реалізуйте можливість перебору елементів колекції у циклі наперед.
     */
    internal class Program
    {
        static void Main(string[] args)
        {
            var dictionary = new MyDictionary<string, string>(5); //Создаем екземпляр класса MyDictionary зарытый типами string и string.

            dictionary.Add(0, "стол", "table"); //Вызываем метод добавление пары ключь-значение в коллекцию словарь
            dictionary.Add(1, "яблоко", "aplle");
            dictionary.Add(2, "карандаш", "pencil");
            dictionary.Add(3, "солнце", "sun");
            dictionary.Add(4, "блокнот", "notepad");

            foreach (var item in dictionary)
            {
                Console.WriteLine(item); //Отображение содержимого с помощью индексатора
            }

            Console.WriteLine(new string('-', 20));
            Console.WriteLine("Вторая запись в словаре:");
            Console.WriteLine(dictionary[1]); //Поиск записи в словаре
            Console.WriteLine(new string('-', 20));
            Console.WriteLine("Размер словаря:");
            Console.WriteLine(dictionary.Lenght + " слов"); //Отображение длины словаря с помощью вызова метода Lenght который возвращает значение которое равно колличеству значений в словаре
            Console.WriteLine(new string('-', 50));

            // Delay.
            Console.ReadKey();
        }
    }
}
