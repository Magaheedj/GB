﻿// Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина 
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
}
