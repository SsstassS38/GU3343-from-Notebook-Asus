// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

int[] InitArray()
{
    int[] result = new int[4];
    Random rnd = new Random();
    for (int i = 0; i < result.Length; i++)
    {
        result[i] = rnd.Next(1, 100);
    }
    return result;
}
void Print(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

int GetNumberMax(int[] array)
{
    int numbermax = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if(array[i] > numbermax)
            numbermax = array[i];
    }
    return numbermax;
}
int GetNumberMin(int[] array)
{
    int numbermin = array[0];
    for (int i = 0; i < array.Length; i++)
    {
        if(array[i] < array[0])
            numbermin = array[i];
    }
    return numbermin;
}

int[] array = InitArray();
Print(array);
int result = GetNumberMax(array) - GetNumberMin(array);
Console.WriteLine($"Разница между максимальным эл-ом и минимальным эл-м: {result} ");
