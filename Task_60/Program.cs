void Matrix(int[,,] matrix)
{
    int count = 10;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int t = 0; t < matrix.GetLength(2); t++)
            {
                matrix[t, i, j] += count;
                count += 3;
            }
        }
    }
}

void PrintMatrix(int[,,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.WriteLine();
            for (int t = 0; t < matrix.GetLength(2); t++)
            {
                Console.Write($"{matrix[i, j, t]}({i},{j},{t}) ");
            }
        }
    }
}

Console.Clear();
int[,,] matrix = new int[2, 2, 2];
Matrix(matrix);
PrintMatrix(matrix);


