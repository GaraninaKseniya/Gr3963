// Задача №43 
// Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
// значения b1, k1, b2 и k2 задаются пользователем. b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; 5,5) 

// метод читает данные от пользователя
int ReadData(string msg)
{
  Console.WriteLine(msg);
  return int.Parse(Console.ReadLine() ?? "0");
}

// метод нахождения точки пересечения 2 прямых, заданных уравнениями
(double x, double y) CrossPoint(double k1, double b1, double k2, double b2)
{
  double coorX = (b1 - b2) / (k2 - k1);
  double coorY = (k2 * b1 - k1 * b2) / (k2 - k1);
  return (coorX, coorY);
}

// метод выводит ответ пользователю
void PrintData(string msg)
{
  Console.WriteLine(msg);
}

double K1 = ReadData("Введите k1 для уравнения y = k1 * x + b1: ");
double B1 = ReadData("Введите b1 для уравнения y = k1 * x + b1: ");
double K2 = ReadData("Введите k2 для уравнения y = k2 * x + b2: ");
double B2 = ReadData("Введите b2 для уравнения y = k2 * x + b2: ");
(double x, double y) pointA = CrossPoint(K1, B1, K2, B2);
PrintData($"Координаты точки пересечения двух прямых : {pointA}");
