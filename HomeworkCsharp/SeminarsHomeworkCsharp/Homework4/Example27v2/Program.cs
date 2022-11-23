/*Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
452 -> 11
82 -> 10
9012 -> 12
*/

Console.WriteLine("Введите число: ");
string numberStr = Console.ReadLine();
int number = int.Parse(numberStr);
int sum = 0;

while(number > 0)
{
    sum = sum + number % 10;
    number = number / 10;
}
Console.Write($"Сумма цифр введeнного числа составляет {sum}");