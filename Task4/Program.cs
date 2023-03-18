using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    /*
    Використовуючи Visual Studio, створіть проект за шаблоном Console Application. 
    Створіть метод, що розширює: public static T[ ] GetArray(this IEnumerable list){…} 
    Застосуйте розширюючий метод до екземпляра типу MyList, розробленого в домашньому завданні 2 для даного уроку. 
    Виведіть на екран значення елементів масиву, який повернув метод GetArray(), що розширює метод.
     */
    static class StaticClass
    {
        public static T[] GetArray<T>(this IEnumerable<T> list) //Статический метод принимающий переменную перечислитель и возвращающий массив
        {
            T[] array = new T[list.Count()]; //Создание массива длинной равной длинне list

            int i = 0;

            foreach (T item in list) //Копируем элементы перечислителя в массив
            {
                array[i] = item;
                i++;
            }

            return array;
        }
    }

    class Program
    {
        static void Main()
        {

            MyList<int> list = new MyList<int>(); //Создание екземпляра класса MyList закрытый типом int

            for (int i = 0; i < 8; i++)
                list.Add(i);  //Добавление элементов в список

            int[] arr = list.GetArray(); //Копирование элементов списка в массив

            foreach (int t in arr)
                Console.Write("{0}  ", t); //Отображение элементов массива

            // Delay.
            Console.ReadKey();
        }
    }
}

