﻿using System;

namespace Task029
{
    class Program
    {
        static void Main(string[] args)
        {

// Задача 31: Задайте массив из 12 элементов, заполненный случайными числами из промежутка [-9, 9]. Найдите сумму отрицательных
// и положительных элементов массива.
// Например, в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6] сумма положительных чисел равна 29, сумма отрицательных равна -20
int[] array = new int[12];
Random rand = new Random();
//int a = new Random().Next(1, 2);

int sumPositive = 0; //сумма положительных чисел
int sumNegative = 0; //сумма отрицательных чисел

// for (int i = 0; i < array.Length; i++)
// {
//     
// }



for (int i = 0; i < array.Length; i++)
{
    array[i] = rand.Next(-9, 10);

    if (array[i] > 0) //если элемент массива положительный
    {
        sumPositive += array[i]; //накопить положительную сумму
    }
    if (array[i] < 0) //если элемент массива отрицательный
    {
        sumNegative += array[i]; //накопить отрицательную сумму
    }
}
Console.WriteLine('[' + string.Join(", ", array) + ']');
Console.Write($"Сумма положительных чисел = {sumPositive}, отрицательных = {sumNegative}");


        }
    }
}
