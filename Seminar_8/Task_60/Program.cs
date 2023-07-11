// Задача 60.  Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
//             Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
//             Массив размером 2 x 2 x 2
//             66(0,0,0) 25(0,1,0)
//             34(1,0,0) 41(1,1,0)
//             27(0,0,1) 90(0,1,1)
//             26(1,0,1) 55(1,1,1)

Console.WriteLine("Задайте размерность трехмерного массива по M, по N и по O - ");
int m = InputNumbers("Введите M: ");
int n = InputNumbers("Введите N: ");
int o = InputNumbers("Введите O: ");
int[,,] array = new int[m, n, o];

int InputNumbers(string input)
{
    Console.Write(input);
    int output = Convert.ToInt32(Console.ReadLine());
    return output;
}

void WriteArray(int[,,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                Console.Write($"{array[i, j, k]} ({i},{j},{k}); ");
            }
            Console.WriteLine();
        }
    }
}

void CreateArray(int[,,] array)
{
    int[] temp = new int[array.GetLength(0) * array.GetLength(1) * array.GetLength(2)];
    int number;
    for (int i = 0; i < temp.GetLength(0); i++)
    {
        temp[i] = new Random().Next(10, 100);
        number = temp[i];
        if (i >= 1)
        {
            for (int j = 0; j < i; j++)
            {
                while (temp[i] == temp[j])
                {
                    temp[i] = new Random().Next(10, 100);
                    j = 0;
                    number = temp[i];
                }
                number = temp[i];
            }
        }
    }
    int count = 0;
    for (int m = 0; m < array.GetLength(0); m++)
    {
        for (int n = 0; n < array.GetLength(1); n++)
        {
            for (int o = 0; o < array.GetLength(2); o++)
            {
                array[m, n, o] = temp[count];
                count++;
            }
        }
    }
}

CreateArray(array);
Console.WriteLine("Полученный массив: ");
WriteArray(array);

