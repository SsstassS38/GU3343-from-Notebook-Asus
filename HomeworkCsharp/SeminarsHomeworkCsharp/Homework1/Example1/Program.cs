/* Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
a = 2 b = 10 -> max = 10
a = -9 b = -3 -> max = -3
*/
Console.WriteLine($"Введите два числа A и B");
String numberStr1 = Console.ReadLine();
String numberStr2 = Console.ReadLine();
int number1 = int.Parse(numberStr1);
int number2 = int.Parse(numberStr2);
int max = 0;
if(number1 > number2) max = number1;
if(number1 < number2) max = number2;
Console.WriteLine($"большее число из двух введенных является {max}");