// Задача 38: Задайте массив натуральных чисел.
//            Найдите разницу между максимальным и минимальным элементом массива.
//            (не использовать стандартные функции/методы).
//            [3 7 22 2 78] -> 76

Console.Write("Введите количество элементов массива: ");
int a = Convert.ToInt32(Console.ReadLine());
int[] array = GetRandomArray();

void mas(int a)
{
    Random rand = new Random();
    for (int i = 0; i < a; i++)
    {
        randomArray[i] = new Random().Next(1, 100);
        Console.Write($"{randomArray[i]:F2} ");
    }
}

int raz(int[] randomArray)
{
    int min = randomArray[0];
    int max = randomArray[0];
    int i = 1;
    while (i < randomArray.Length)
    {
        if (max < randomArray[i])
            max = randomArray[i];
        if (min > randomArray[i])
            min = randomArray[i];
        i = i + 1;
    }
    return max - min;
}

mas(a);
Console.Write(
    $"\nРазница между максимальным и минимальным элементов массива: {raz(randomArray):F2}"
);
