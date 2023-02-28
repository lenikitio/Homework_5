﻿// Задача 36: Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

Console.Clear();

int[] GetRandomArray(int size, int min, int max)
{
    int[] result = new int[size];
    Random rnd = new Random();
    for(int i = 0; i < size; i++)
    result[i] = rnd.Next(min, max + 1);
    Console.WriteLine($"Ваш массив: [{string.Join(", ", result)}]");
    return result;
}

void GetSum(int[] array)
{
    int sum = 0;
    for(int i = 1; i < array.Length; i += 2)
        sum += array[i];
    Console.WriteLine($"Сумма всех элементов массива, стоящих на нечётных позициях равна: {sum}");
}

int[] arr = GetRandomArray(10, -8, 10);
GetSum(arr);
