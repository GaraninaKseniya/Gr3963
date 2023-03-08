// Задача №40
// Напишите программу, которая принимает на вход три числа и проверяет, 
// может ли существовать треугольник со сторонами такой длины.
// (a<=b+c; b<=a+c; c<=a+b)

// метод читает данные от пользователя
int ReadData(string msg)
{
  Console.WriteLine(msg);
  return int.Parse(Console.ReadLine() ?? "0");
}

// метод проверяет возможность существования треугольника со сторонами такой длины
bool TriangleTest(int a, int b, int c)
{
  bool res = false;
  if (a <= b + c && b <= a + c && c <= a + b)
  {
    res = true;
  }
  return res;
}

// метод выводит ответ пользователю
void PrintData(string msg)
{
  Console.WriteLine(msg);
}

int a = ReadData("Введите длину стороны A: ");
int b = ReadData("Введите длину стороны B: ");
int c = ReadData("Введите длину стороны C: ");
PrintData($"Возможность существования треугольника со сторонами такой длины: {TriangleTest(a, b, c)}");