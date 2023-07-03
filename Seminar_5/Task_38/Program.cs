// Задача 38: Задайте массив натуральных чисел.
//            Найдите разницу между максимальным и минимальным элементом массива.
//            (не использовать стандартные функции/методы).
//            [3 7 22 2 78] -> 76

Console.Write("Введите количество элементов из которых состоит массив: ");
int a = Convert.ToInt32(Console.ReadLine());
int[] array = new int[a];

void Chisla(int a)
{
    Console.WriteLine("Введите произвольные числа в массив - ");
    for (int i = 0; i < a; i++)
    {
        Console.Write($"{(i + 1)} число: ");
        array[i] = Convert.ToInt32(Console.ReadLine());
    }
}

int Raznica(int[] array)
{
    int min = array[0];
    int max = array[0];
    for (int i = 1; i < array.Length; i++)
    {
        if (max < array[i])
        {
            max = array[i];
        }
        if (min > array[i])
        {
            min = array[i];
        }
    }
    return max - min;
}

Chisla(a);
Console.Write($"Разница между максимальным и минимальным элементами массива: {Raznica(array)}");
