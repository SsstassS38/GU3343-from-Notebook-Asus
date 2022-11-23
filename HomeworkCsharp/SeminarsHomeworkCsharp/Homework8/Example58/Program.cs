/*Задача 54: Задайте двумерный массив. Напишите программу, 
которая упорядочит по убыванию элементы каждой строки двумерного массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
В итоге получается вот такой массив:
7 4 2 1
9 5 3 2
8 4 4 2
*/

void FillArrayRandomNumbers(int[,] array)
{
    Random rnd = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = rnd.Next(0, 10);
        }
    }
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine("");
    }
}

Console.WriteLine("введите количество строк");
int linesVol = int.Parse(Console.ReadLine());
Console.WriteLine("введите количество столбцов");
int columnsVol = int.Parse(Console.ReadLine());
int[,] numbers = new int[linesVol, columnsVol];
FillArrayRandomNumbers(numbers);
Console.WriteLine();
Console.WriteLine("Рандомный массив");
PrintArray(numbers);

for (int i = 0; i < numbers.GetLength(0); i++)
{
    for (int j = 0; j < numbers.GetLength(1) - 1; j++)
    {
        for (int a = 0; a < numbers.GetLength(1) - 1; a++)
        {
            int temp = 0;
            if (numbers[i, a] < numbers[i, a + 1]) 
            {
                temp = numbers[i, a];
                numbers[i, a] = numbers[i, a + 1];
                numbers[i, a + 1] = temp;
            }
        }
    }
}
Console.WriteLine();
Console.WriteLine("Упорядоченный массив");
PrintArray(numbers);