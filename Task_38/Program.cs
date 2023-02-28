// Задача 38: Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

Console.Clear();

double[] GetRealArray(int size, int min, int max)
{
    double[] result = new double[size];
    Random rnd = new Random();
    for(int i = 0; i < result.Length; i++)
    result[i] = rnd.Next(min, max + 1) + rnd.NextDouble();
    Console.WriteLine($"Ваш массив: [{string.Join(", ", result)}]");
    return result;
}

void GetDif(double[] arrey)
{
    double max = arrey[0];
    double min = arrey[1];
    foreach(double elem in arrey)
    {
        if( elem >= max)
        max = elem;
        else if(elem <= min)
        min = elem;
    }
    Console.WriteLine($"Разность между {max} и {min} = {max - min}");
}
double[] arr = GetRealArray(10, -2, 20);
GetDif(arr);