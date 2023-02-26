// Задача №25 
// Напишите цикл, который принимает на вход два числа (A и B) 
// и возводит число A в натуральную степень B. 

// метод читает данные от пользователя
int ReadData(string msg)
{
  Console.WriteLine(msg);
  return int.Parse(Console.ReadLine() ?? "0");
}

// метод возводит число A в натуральную степень B
long ExponentNum(int numA, int numB)
{
  long res = numA;
  for (int i = 2; i <= numB; i++)
  {
    res = res * numA;
  }
  return res;
}

// метод выводит ответ пользователю
void PrintData(string msg)
{
  Console.WriteLine(msg);
}

int numberA = ReadData("Введите число A: ");
int numberB = ReadData("Введите число B: ");
long res = ExponentNum(numberA, numberB);
PrintData($"Число A в степени B составляет {res}");
