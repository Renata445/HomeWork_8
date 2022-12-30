int [,] PascalMatrix (int numberRows)
{
    int rows = numberRows;
    int columns = numberRows + 2;
    int [,] matrix = new int [rows, columns];
    matrix[0, 0 ] = 0;
    matrix[0, 1 ] = 1;
    matrix[0, 2 ] = 0;
    for (int i = 1; i < matrix.GetLength(0); i++)
    {
        for (int j = 1; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = matrix[i - 1, j - 1] + matrix[i - 1, j];
        }
    }
    return matrix;
}

void PrintPascalMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int k = matrix.GetLength(0); k > i; k--)
            {
                Console.Write("  ");
            }
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                Console.Write("{0,4}", matrix[i, j]);
            }
        Console.WriteLine();
    }
}
Console.Clear();
Console.WriteLine("Введите количество строк треугольника Паскаля:");
int numberRows = int.Parse(Console.ReadLine());
int [,] matrix = PascalMatrix(numberRows);
Console.WriteLine();
PrintPascalMatrix(matrix);
