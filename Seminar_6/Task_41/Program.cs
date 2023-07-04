// Задача 41: Пользователь вводит с клавиатуры M чисел.
//         Посчитайте, сколько чисел больше 0 ввёл пользователь.
//         [0, 7, 8, -2, -2] -> 2
//         [-1, -7, 567, 89, 223] -> 3

Console.Write("Введите количество элементов из которых состоит массив: ");
int a = Convert.ToInt32(Console.ReadLine());
int[] array = new int[a];

void massiv(int a)
{
    for (int i = 0; i < a; i++)
    {
        Console.Write($"Введите {i + 1} элемент массива: ");
        array[i] = Convert.ToInt32(Console.ReadLine());
    }
}

int pologit(int[] array)
{
    int sum = 0;
    for (int i=0; i < array.Length; i++)
    {
        if (array[i] > 0)
        {
            sum = sum + 1;
        }
    }
    return sum;
}

massiv(a);
Console.Write($"Вы ввели в массив чисел больше нуля: {pologit(array)}");
