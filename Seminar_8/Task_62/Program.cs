// Задача 62.  Напишите программу, которая заполнит спирально массив 4 на 4.
//             Например, на выходе получается вот такой массив:
//             01 02 03 04
//             12 13 14 05
//             11 16 15 06
//             10 09 08 07

// int[,,] Random3dArray( int field, int rows, int columns);
// int[,,] newArray = new int[field, rows, columns]; //выделяем память под двумерный массив
// for(int i = 0; i < field; i++) // прохождение по строкам
// }
// {
//     for(int j = 0; j < rows; j++) // прохождение по столбцам
// {
//     for(int k = 0; k < columns; k++)

// { newArray[i,j,k] = i + j + k;
// }
// }
// } return newArray;
// }
// void Show3dArray(int[,,] array)
// // показываем двумерный массив
// { for (int i = 0; i < array.GetLength(0); i++)
// {
//     for(int j = 0; j < array.GetLength(1); j++)
//     {
//         for(int k = 0; k < array.GetLength(2); k++)
//         {
//             Console.Write("[" + i + "," + j + "]" + array[i, j, k] + " ");
//             }
//             Console.WriteLine();
//             }
//             Console.WriteLine();
//             }
//             Console.WriteLine();
//             }
//             Console.Write("Input number of field: "); // запросили количество полей
//             int n = Convert.ToInt32(Console.ReadLine());
//             Console.Write("Input number of rows: "); // запросили длину строки
//             int m = Convert.ToInt32(Console.ReadLine());
//             Console.Write("Input number of columns: "); // запросили количество столбцов
//             int l = Convert.ToInt32(Console.ReadLine());

//             int[,,] array = Random3dArray(m, n, l);

//             Show3dArray(array);

Console.WriteLine($"Введите размер массива X x Y x Z: ");
int x = InputNumbers("Введите X: ");
int y = InputNumbers("Введите Y: ");
int z = InputNumbers("Введите Z: ");
//Console.WriteLine($"");

int[,,] array3D = new int[x, y, z];
CreateArray(array3D);
WriteArray(array3D);

int InputNumbers(string input)
{
    Console.Write(input);
    int output = Convert.ToInt32(Console.ReadLine());
    return output;
}

void WriteArray(int[,,] array3D)
{
    for (int i = 0; i < array3D.GetLength(0); i++)
    {
        for (int j = 0; j < array3D.GetLength(1); j++)
        {
            for (int k = 0; k < array3D.GetLength(2); k++)
            {
                Console.Write($"{array3D[i, j, k]} ({i},{j},{k}); ");
            }
            Console.WriteLine();
        }
    }
}

void CreateArray(int[,,] array3D)
{
    int[] temp = new int[array3D.GetLength(0) * array3D.GetLength(1) * array3D.GetLength(2)];
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
    for (int x = 0; x < array3D.GetLength(0); x++)
    {
        for (int y = 0; y < array3D.GetLength(1); y++)
        {
            for (int z = 0; z < array3D.GetLength(2); z++)
            {
                array3D[x, y, z] = temp[count];
                count++;
            }
        }
    }
}
