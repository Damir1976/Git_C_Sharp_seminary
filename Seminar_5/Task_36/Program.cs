// Задача 36: Задайте одномерный массив, заполненный случайными числами.
//            Найдите сумму элементов, стоящих на нечётных индексах.
//            [3, 7, 23, 12] -> 19
//            [-4, -6, 89, 6] -> 0

Console.Write("Введите количество элементов в массиве: ");
int a = Convert.ToInt32(Console.ReadLine());
int[] array = new int[a];

void massiv(int a)
{
    for (int i = 0; i < a; i++)
    {
        array[i] = Random.Shared.Next(0, 100);
        Console.Write(array[i] + ", ");
    }
}

int kol(int[] array)
{
    int sum = 0;
    int i = 1;
    while (i < array.Length)
    {
        sum = sum + array[i];
        i = i + 2;
    }
    return sum;
}

massiv(a);
Console.Write($"\n Сумма числе, стоящих на нечётных индексах массива = {kol(array)}");
