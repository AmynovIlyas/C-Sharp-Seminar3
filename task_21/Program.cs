// Задача 21. Напишите программу, которая принимает на вход координаты двух точек 
// и находит расстояние между ними в 2D пространстве
// Например:
// A (3,6); B (2,1) --> 5,09
// A (7,-5); B (1,-1) --> 7,21

int x1 = Prompt("Введите координату x1: ");
int y1 = Prompt("Введите координату y1: ");
int x2 = Prompt("Введите координату x2: ");
int y2 = Prompt("Введите координату y2: ");
double distance = FindDistance(x1, y1, x2, y2);
Console.WriteLine($"A({x1},{y1}); B ({x2},{y2}) --> {distance}");

double FindDistance(int xa, int ya, int xb, int yb)
{
    double rasst = Math.Sqrt(Math.Pow(xa - xb, 2) + Math.Pow(ya - yb, 2));
    rasst = Math.Round(rasst, 2);
    return rasst;
}

int Prompt(string message)
{
    Console.WriteLine(message);
    int result = Convert.ToInt32(Console.ReadLine());
    return result;
}


