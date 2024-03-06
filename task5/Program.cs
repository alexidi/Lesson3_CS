// Задайте массив символов (тип char []). Создайте строку из
// символов этого массива. 


string input = Console.ReadLine()!;
char[] MasChar = new char[input.Length];

for (int i = 0; i < input.Length; i++)
{
    MasChar[i] = input[i];
}

void PrintMasChar(char[] MasChar)
{
    foreach (char i in MasChar)
    {
        Console.WriteLine(i);
    }
}
PrintMasChar(MasChar);