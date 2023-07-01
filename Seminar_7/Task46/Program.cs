const int ROWS = 3;
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
}
void PrintMatrix(int[,] matrix)
{
    for(int m = 0; m < matrix.GetLength(0); m++)
    {
        for(int n = 0; n < matrix.GetLength(1); n++)
        {
            Console.Write($"{matrix[m, n]}\t");
        }
        Console.WriteLine();
    }
}
int[,] myMatrix = GetRandomMatrix(ROWS, COLUMNS); 
PrintMatrix(myMatrix);






