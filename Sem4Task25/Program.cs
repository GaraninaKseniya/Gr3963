// Задача №25 
// Напишите цикл, который принимает на вход два числа (A и B) 
// и возводит число A в натуральную степень B. 
// * Написать калькулятор с операциями +, -, /, * и возведение в степень. 

// метод читает данные от пользователя (число)
int ReadData(string msg)
{
  Console.WriteLine(msg);
  return int.Parse(Console.ReadLine() ?? "0");
}
// метод читает данные от пользователя (символ)
char ReadSign(string msg)
{
    Console.WriteLine(msg);
    return Convert.ToChar(Console.ReadLine() ?? "0");
}

// калькулятор
double Calculator(int numA, char sign, int numB) 
{
  if (sign == '+') return numA + numB;
  if (sign == '-') return numA - numB;
  if (sign == '*') return numA * numB;
  if (sign == '/' && numB != 0) return numA / numB;
  if (sign == '^') return ExponentNum(numA, numB);
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
char sign = ReadSign("Введите действие (+, -, /, *, ^): ");
int numberB = ReadData("Введите число B: ");
double res = Calculator(numberA, sign, numberB);
PrintData($"{numberA} {sign} {numberB} = {res}");


// // Задача №25 
// // Напишите цикл, который принимает на вход два числа (A и B) 
// // и возводит число A в натуральную степень B. 

// // метод читает данные от пользователя
// int ReadData(string msg)
// {
//   Console.WriteLine(msg);
//   return int.Parse(Console.ReadLine() ?? "0");
// }

// // метод возводит число A в натуральную степень B
// long ExponentNum(int numA, int numB)
// {
//   long res = numA;
//   for (int i = 2; i <= numB; i++)
//   {
//     res = res * numA;
//   }
//   return res;
// }

// // метод выводит ответ пользователю
// void PrintData(string msg)
// {
//   Console.WriteLine(msg);
// }

// int numberA = ReadData("Введите число A: ");
// int numberB = ReadData("Введите число B: ");
// long res = ExponentNum(numberA, numberB);
// PrintData($"Число A в степени B составляет {res}");