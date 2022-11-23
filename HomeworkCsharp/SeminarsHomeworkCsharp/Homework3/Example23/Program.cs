/* Задача 23
Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
3 -> 1, 8, 27
5 -> 1, 8, 27, 64, 125
*/

Console.WriteLine("Введите любое число: ");
string numberStr = Console.ReadLine();
int number = int.Parse(numberStr);
for(int i = 1; i <= number; i++)
{
    if(i != number)
    Console.Write($"{(i * i) * i}, ");
    else
     Console.Write($"{(i * i) * i} ");
}