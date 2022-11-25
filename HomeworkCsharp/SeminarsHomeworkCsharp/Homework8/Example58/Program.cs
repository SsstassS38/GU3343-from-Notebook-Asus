/*Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18
*/

int GetNumber(string msg)
{
    Console.Write(msg);
    int userNumber = Convert.ToInt32(Console.ReadLine()); ;
    return userNumber;
}

void FillArrayRandomNumbers(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(1, 10); 
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
        Console.WriteLine();
    }
}

int sizeMatr = GetNumber("размерность матриц: ");
int[,] matrixA = new int[sizeMatr, sizeMatr];
int[,] matrixB = new int[sizeMatr, sizeMatr];
FillArrayRandomNumbers(matrixA);
FillArrayRandomNumbers(matrixB);
int[,] matrixC = new int[sizeMatr, sizeMatr];

for (int i = 0; i < sizeMatr; i++)
{
    for (int j = 0; j < sizeMatr; j++)
    {
        for (int k = 0; k < sizeMatr; k++)
        {
            matrixC[i, j] = matrixC[i, j] + (matrixA[i, k] * matrixB[k, j]);
        }
    }
}
Console.WriteLine("Матрица - А");
PrintArray(matrixA);
Console.WriteLine();
Console.WriteLine("Матрица - В");
PrintArray(matrixB);
Console.WriteLine();
Console.WriteLine("Произведение матриц А*В");
PrintArray(matrixC);

