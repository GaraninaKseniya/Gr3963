// Задача №21 
// Напишите программу, которая принимает на вход координаты двух точек 
// и находит расстояние между ними в 3D пространстве.

// метод читает данные от пользователя
int ReadData(string msg)
{
  Console.WriteLine(msg);
  return int.Parse(Console.ReadLine() ?? "0");
}

// метод вычисляет расстояние между точками
double CalcLen(int x1, int x2, int y1, int y2, int z1, int z2)
{
  return Math.Sqrt((x2-x1)*(x2-x1)+(y1-y2)*(y1-y2)+(z1-z2)*(z1-z2));
} 

// метод выводит ответ пользователю
void PrintData(string msg, double val)
{
  Console.WriteLine(msg + val);
}

int x1 = ReadData("Введите координату Х точки А: ");
int y1 = ReadData("Введите координату Y точки А: ");
int z1 = ReadData("Введите координату Z точки А: ");
int x2 = ReadData("Введите координату Х точки В: ");
int y2 = ReadData("Введите координату Y точки В: ");
int z2 = ReadData("Введите координату Z точки В: ");
double res = CalcLen(x1, x2, y1, y2, z1, z2);
PrintData("Расстояние между точками А и В: ", res); 