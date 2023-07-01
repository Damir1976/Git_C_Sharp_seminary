// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

Console.Write("Введите пятизначное число: ");
int number = Convert.ToInt32(Console.ReadLine());
int rebmun,a,b=0;
if (number > 9999 && number < 100000)
{
for (rebmun = number; number != 0; number = number/10)
{
a = number % 10;
b = b*10+a;
}
if (rebmun == b)
Console.Write($"Число {rebmun} является палиндромом");
else
Console.Write($"Число {rebmun} не является палиндромом");
} 
else
Console.Write("К сожалению вы ввели не пятизначное число!!!");