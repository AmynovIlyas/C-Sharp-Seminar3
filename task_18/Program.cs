// Задача 18. Напишите программу, которая по заданному номеру четверти, 
// показывает диапазон возможных координат точек в этой четверти (x и y)


int quarter = Prompt("Введите номер четверти: ");
ShowQuarter(quarter);

int Prompt(string message)
{
    Console.WriteLine(message);
    int quart = int.Parse(Console.ReadLine()!);
    return quart;
}

void ShowQuarter(int num)
{
    if (num == 1)
    {
        Console.WriteLine("Возможные координаты точек: x > 0; y > 0");
    }
    else if (num == 2)
    {
        Console.WriteLine("Возможные координаты точек: x < 0; y > 0");
    }
     else if (num == 3)
    {
        Console.WriteLine("Возможные координаты точек: x < 0; y < 0");
    }
     else if (num == 4)
    {
        Console.WriteLine("Возможные координаты точек: x > 0; y < 0");
    }
    else
    {
        Console.WriteLine("Четверти с заданным номером не существует");
    }
}
