using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    /*
    Використовуючи Visual Studio, створіть проект за шаблоном Console Application. 
    Створіть колекцію MyList. Реалізуйте у найпростішому наближенні можливість використання її екземпляра 
    аналогічно екземпляру класу List. Мінімально необхідний інтерфейс взаємодії 
    з екземпляром повинен включати метод додавання елемента, 
    індексатор для отримання значення елемента за вказаним індексом і властивість тільки для читання 
    для отримання загальної кількості елементів. 
    Реалізуйте можливість перебору елементів колекції у циклі наперед.
     */
    internal class Program
    {
        static void Main(string[] args)
        {
            MyList<int> list = new MyList<int>(); //Создание параметризированной коллекции MyList с типом int
            for (int i = 0; i < 5; i++)
                list.Add(i); //Добавляем элементы в коллекцию

            Console.WriteLine("Длина массива = {0}", list.Count); //Отображаем длинну коллекции

            foreach (int item in list)
                Console.Write("{0}  ", item); //Отображаем содержимое коллекции

            // Delay.
            Console.ReadKey();
        }
    }
}
