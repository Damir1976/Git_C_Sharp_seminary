// Задача 56:  Задайте прямоугольный двумерный массив. Напишите программу, которая будет
//             находить строку с наименьшей суммой элементов.
//             Например, задан массив:
//             1 4 7 2
//             5 9 2 3
//             8 4 2 4
//             5 2 6 7
//             Программа считает сумму элементов в каждой строке и выдаёт номер строки
//             с наименьшей суммой элементов: 1 строка

Console.Write("Введите размерность прямоугольного двумерного массива: ");
int m = Convert.ToInt32(Console.ReadLine());
int n = m;
int[,] randomArray = new int[m, n];

void massiv(int m, int n)
{
    Random rand = new Random();
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            randomArray[i, j] = rand.Next(1, 10);
        }
    }
}

void printmassiv(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
}

int summaline(int[,] array, int i)
{
    int summa = array[i, 0];
    for (int j = 1; j < array.GetLength(1); j++)
    {
        summa += array[i, j];
    }
    return summa;
}

massiv(m, n);
Console.WriteLine("Сгеренированный массив: ");
printmassiv(randomArray);
int minsumma = 1;
int sum = summaline(randomArray, 0);
for (int i = 1; i < randomArray.GetLength(0); i++)
{
    if (sum > summaline(randomArray, i))
    {
        sum = summaline(randomArray, i);
        minsumma = i + 1;
    }
}
Console.WriteLine($"Наименьшая сумма из {m} элементов (={sum}) находится в строке: {minsumma}.");
