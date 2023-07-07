// Задача 53: Задайте двумерный массив. Напишите программу, которая поменяет местами первую 
//            и последнюю строку массива.
//              1 3 5 7
//              2 8 9 6 
//              3 5 7 9 
//              5 1 2 8
//              6 9 1 3

const int ROWS = 5;
const int COLUMNS = 4;
int[,] GetRandomMatrix(int rows, int columns)
{
    int[,] matrix = new int[rows, columns];
    for(int m = 0; m < matrix.GetLength(0); m++)
    {
        for(int n = 0; n < matrix.GetLength(1); n++)
        {
            matrix[m, n] = m + n;
        }
    }

    return matrix;