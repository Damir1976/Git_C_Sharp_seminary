// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

int[] array = new int[8];

Console.WriteLine("Введите 8 произвольных чисел в массив: ");
for (int i = 0; i < 8; i++)
{
    Console.Write($"{(i+1)} число: ");
    array[i] = Convert.ToInt32(Console.ReadLine());
}
Console.Write("У нас получился вот такой массив: ");
for (int i = 0; i < 8; i++)
{
    Console.Write($"{array[i]}, ");
}
