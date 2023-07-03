// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами.
//            Напишите программу, которая покажет количество чётных чисел в массиве.
//            [345, 897, 568, 234] -> 2

Console.Write("Задайте количество элементов из которых состоит массив: ");
int a = Convert.ToInt32(Console.ReadLine());
int[] array = new int[a];

void massiv(int a)
{
    for (int i = 0; i < a; i++)
    {
        array[i] = Random.Shared.Next(100, 1000);
        Console.Write(array[i] + ", ");
    }
}

int chetnye(int[] array)
{
    int chetnye = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0)
            chetnye = chetnye + 1;
    }
    return chetnye;
}

massiv(a);
Console.Write($"\nКоличество чётных чисел в массиве: {chetnye(array)}");
