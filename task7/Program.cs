Console.Clear();

int[,] CreateMatrix(int rowCount, int columnCount)
{
    int[,] matrix = new int[rowCount, columnCount];
    Random rnd = new Random();

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(1, 1000);
        }
    }
    return matrix;
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j]} ");
        }
        Console.WriteLine();
    }
}

int[,] matrix = CreateMatrix(3, 6);
PrintMatrix(matrix);
foreach (var e in matrix)
{
    if (interesing(e) == true)       
    {
        Console.WriteLine(e);
    }
}

bool interesing(int value)
{
    int sumOgDigits = GetsumOfDigits(value);
    if (sumOgDigits % 2 == 0)
    {
        return true;
    }
    return false;
}

int GetsumOfDigits(int value)
{
    int summ = 0;
    while (value > 0)
    {
        summ = summ + value % 10;
        value = value / 10;
    }
    return summ;
}