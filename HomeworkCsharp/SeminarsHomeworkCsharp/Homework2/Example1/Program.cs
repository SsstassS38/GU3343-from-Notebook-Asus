/*Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
456 -> 5
782 -> 8
918 -> 1
*/

Console.Write("Введите трехзначное число: ");
string numberStr = Console.ReadLine();
int number = int.Parse(numberStr);

if (number >= 100 && number <= 999 || number <= -100 && number >= -999)
{
    int result = Math.Abs ((number / 10) % 10);
    Console.WriteLine($"Вторая цифра 3х значного числа: {result}");
}
else
{
    Console.WriteLine($"Данные не верные ");
}