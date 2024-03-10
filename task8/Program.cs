
int[] Random_array(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(1, 20);
    }
    return array;
}

void Print_array(int[] array)
{
    foreach (var item in array)
    {
        Console.Write($"{item} ");
    }
}
    Console.WriteLine();



    Console.WriteLine("Введите размер массива: ");
    int n = Convert.ToInt32(Console.ReadLine());
    int[] array = Random_array(new int[n]);

    Print_array(array);