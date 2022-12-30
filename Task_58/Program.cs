void InputMatrix_1(int[,] matrix_1)
{
    for(int i = 0; i < matrix_1.GetLength(0); i++)
    {
        for(int j = 0; j < matrix_1.GetLength(1); j++)
        {
            matrix_1[i, j] = new Random().Next(-10, 11);
        }
    }
}

void InputMatrix_2(int[,] matrix_2)
{
    for(int i = 0; i < matrix_2.GetLength(0); i++)
    {
        for(int j = 0; j < matrix_2.GetLength(1); j++)
        {
            matrix_2[i, j] = new Random().Next(-10, 11);
        }
    }
}

void ResultMatrix(int[,] resultmatrix)
{
    for(int i = 0; i < resultmatrix.GetLength(0); i++)
    {
        for(int j = 0; j < resultmatrix.GetLength(1); j++)
        {
            resultmatrix[i, j] = new Random().Next(-10, 11);
        }
    }
}

void PrintMatrix(int[,] matrix)
{
    for(int i = 0; i < matrix.GetLength(0); i++)
    {
        for(int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j]} \t");
        }
        Console.WriteLine();
    }
}

void CompositionMatrix(int[,] matrix_1, int[,] matrix_2, int[,] resultmatrix)
{
    for(int i = 0; i < resultmatrix.GetLength(0); i++)
    {
        for(int j = 0; j < resultmatrix.GetLength(1); j++)
        {
            int sum = 0;
            for(int k = 0; k < matrix_1.GetLength(1); k++)
            {
                sum += matrix_1[i, k] * matrix_2[k, j];
            }
            resultmatrix[i, j] = sum;
            Console.Write($"{resultmatrix[i, j]} \t");
        }
        Console.WriteLine();
    }
}

Console.Clear();
Console.Write("Введите размер первой матрицы: ");
int[] size_1 = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToArray();
int[,] matrix_1 = new int[size_1[0], size_1[1]];
Console.Write("Введите размер второй матрицы: ");
int[] size_2 = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToArray();
int[,] matrix_2 = new int[size_2[0], size_2[1]];
Console.Write("Введите размер конечной матрицы: ");
int[] size_3 = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToArray();
int[,] resultmatrix = new int[size_3[0], size_3[1]];
Console.WriteLine("Начальный массив:");
InputMatrix_1(matrix_1);
PrintMatrix(matrix_1);
Console.WriteLine();
InputMatrix_2(matrix_2);
PrintMatrix(matrix_2);
Console.WriteLine("Конечный массив:");
CompositionMatrix(matrix_1, matrix_2, resultmatrix);

