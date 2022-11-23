/*Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
2, 3, 7 -> 7
44 5 78 -> 78
22 3 9 -> 22
*/
Console.Write($"Введите три числа через ввод: ");
String numberStr1 = Console.ReadLine() ??"";
String numberStr2 = Console.ReadLine() ??"";
String numberStr3 = Console.ReadLine() ??"";
int number1 = int.Parse(numberStr1);
int number2 = int.Parse(numberStr2);
int number3 = int.Parse(numberStr3);
int max = 0;
if(number1 > number2) max = number1;
if(number2 > number1) max = number2;
if(number3 > max) max = number3;
Console.Write(max);