// Задача 22. Напишите программу, которая принимает на вход число (N) и выдаёт таблицу квадратов чисел от 1 до N
// Например:
// 5 --> 1, 4, 9, 16, 25
// 2 --> 1, 4

int N = Prompt("Введите число: ");
Console.Write($"{N} --> ");
int finalN = Math.Abs(N);
SquareDigit(finalN);

void SquareDigit(int number)
{
    int i = 1;
    while (i < number) 
    {
        int square = Convert.ToInt32(Math.Pow(i, 2));
        Console.Write($"{square}, ");
        i++;
    }
    Console.Write(Math.Pow(i, 2));
}

int Prompt(string message)
{
    Console.WriteLine(message);
    int result = int.Parse(Console.ReadLine()!);
    return result;
}

