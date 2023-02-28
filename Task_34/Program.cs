// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
//Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

Console.Clear();

int[] GetArray(int size)
{
    int[] result = new int[size];
    Random rnd = new Random();
    for(int i = 0; i < size; i++)
    result[i] = rnd.Next(100, 1000);
    Console.WriteLine($"Ваш массив: [{string.Join(", ", result)}]");
    return result;
}

void GetEvenNum (int[] array)
{
    int count = 0;
    foreach(int elem in array)
    {
        if(elem % 2 == 0)
        count ++;
    }
    Console.WriteLine($"Количество четных элементов в массиве: {count}");
}

int[] arr = GetArray(12);
GetEvenNum(arr);