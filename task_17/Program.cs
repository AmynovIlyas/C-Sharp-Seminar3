// Задача 17. Напишите программу, которая принимает на вход координаты точки (X и Y), 
// причём X != 0 и Y != 0 и выдаёт номер четверти плоскости, в которой находится эта точка

int valueX = Prompt("Введите координату Х: ");
int valueY = Prompt("Введите координату Y: ");
FindQuarterPlane(valueX, valueY);

int Prompt(string message)
{
    Console.WriteLine(message);
    int coordNumber = Convert.ToInt32(Console.ReadLine());
    return coordNumber;
}

void FindQuarterPlane(int x, int y)
{
    if (x > 0 && y > 0)
    {
        Console.WriteLine("1 четверть");
    }
    if (x < 0 && y > 0)
    {
        Console.WriteLine("2 четверть");
    }
    if (x < 0 && y < 0)
    {
        Console.WriteLine("3 четверть");
    }
    if (x > 0 && y < 0)
    {
        Console.WriteLine("4 четверть");
    }
}
