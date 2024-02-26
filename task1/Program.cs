// Напишите программу, которая на вход
// принимает натуральное число N, а на выходе
// показывает его цифры через запятую.

Console.Write("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());
if (n < 10)
{
    Console.Write(n);
}
else
{
    while (n > 0)
    {
        int n_1 = n % 10;
        n /= 10;
        Console.Write($"{n_1++},");
    }
}
