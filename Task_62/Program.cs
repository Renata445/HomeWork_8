void SpiralMatrix(int[,] matrix, int n)
{
    int i = 0, j = 0;
    int value = 1;
    for(int l = 0; l < n * n; l++)
    {
        int k = 0;
        do { matrix[i, j++] = value++; } 
        while (++k < n - 1);
        for (k = 0; k < n - 1; k++) matrix[i++, j] = value++;
        for (k = 0; k < n - 1; k++) matrix[i, j--] = value++;
        for (k = 0; k < n - 1; k++) matrix[i--, j] = value++;
        ++i; ++j;
        n = n < 2 ? 0 : n - 2;
    }
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (matrix[i, j] < 10)
            {
                Console.Write("0" + matrix[i, j]);
                Console.Write(" ");
            }
            else Console.Write(matrix[i, j] + " ");
        }
        Console.WriteLine();
    }
}

Console.Clear();
int size = 4;
int[,] matrix = new int[size, size];
SpiralMatrix(matrix, size);
PrintMatrix(matrix);
