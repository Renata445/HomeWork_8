void InputMatrix(int[,] matrix)
{
    for(int i = 0; i < matrix.GetLength(0); i++)
    {
        for(int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(-10, 11);
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

void MinSumRow(int[,] matrix)
{
    int MinRowSum = 0;
    int MinRow = 0;
    int SumRow = 0;
    for(int i = 0; i < matrix.GetLength(1); i++)
    {
        MinRow += matrix[0, i];
    }
    for(int i = 0; i < matrix.GetLength(0); i++)
    {
        for(int j = 0; j < matrix.GetLength(1); j++)
        {
            SumRow += matrix[i, j];
        }
        if (SumRow < MinRow)
        {
            MinRow = SumRow;
            MinRowSum = i;
        }
        SumRow = 0;
    }
    Console.Write($"{MinRowSum + 1} строка");
}

Console.Clear();
Console.Write("Введите размер матрицы: ");
int[] size = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToArray();
int[,] matrix = new int[size[0], size[1]];
Console.WriteLine("Начальный массив:");
InputMatrix(matrix);
PrintMatrix(matrix);
Console.WriteLine();
MinSumRow(matrix);