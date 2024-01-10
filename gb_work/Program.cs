// Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина 
// которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, либо задать на 
// старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, лучше обойтись 
// исключительно массивами.


using System;

class Program
{
    static void Main()
    {
        // Ввод исходного массива с клавиатуры
        Console.WriteLine("Введите элементы массива, разделяя их пробелом:");
        string  stroka = Console.ReadLine()!;
        string[] array = stroka.Split(' ');

        
    }

    static string[] FilterArray(string[] array)
    {
        // Подсчет количества строк, удовлетворяющих условию
        int count = 0;
        foreach (string element in array)
        {
            if (element.Length <= 3)
            {
                count++;
            }
        }

        // Создание нового массива с подходящими строкам
        string[] newArray = new string[count];
        int index = 0;
        foreach (string element in array)
        {
            if (element.Length <= 3)
            {
                newArray[index] = element;
                index++;
            }
        }

        return newArray;
    }
}
