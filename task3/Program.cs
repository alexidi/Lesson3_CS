// Задайте массив из N случайных целых чисел (N вводится с
// клавиатуры).
// Найдите количество чисел, которые оканчиваются на 1 и
// делятся нацело на 7.
// Пример
// [1 5 11 21 81 4 0 91 2 3]
// => 2


Console.Clear();

int[] Random_mas(int[] mas)
{
    for (int i = 0; i < mas.Length; i++)
    {
        mas[i] = new Random().Next(21, 91);
    }
    return mas;
}

void Print_mas(int[] col)
{
    foreach (var item in col)
    {
        Console.Write($"{item} ");
    }
    Console.WriteLine();
}


int Count_1(int[] mas_1)
{
    int count = 0;
    foreach (var item in mas_1)
    {
        if (item % 10 == 1 && item % 7 == 0)
        {
            count++;
        }
    }
    return count;
}

Console.Write("Введите размерность массива: ");
int n = Convert.ToInt32(Console.ReadLine());

int[] mas = Random_mas(new int[n]);
Print_mas(mas);

Console.WriteLine(Count_1(mas));