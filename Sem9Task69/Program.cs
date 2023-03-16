// Задача №69 
// Напишите программу, которая будет принимать два числа А и В, 
// и возведет число А в степень В с помощью рекурсии. 

// метод читает данные от пользователя
int ReadData(string msg)
{
  Console.WriteLine(msg);
  return int.Parse(Console.ReadLine() ?? "0");
}

// // метод возводит число А в степень В с помощью рекурсии (простой метод)
// long RecPowSimple(int numA, int numB)
// {
//   if (numB <= 1) return numA;
//   else return numA * RecPowSimple(numA, numB-1);
// }

// метод возводит число А в степень В с помощью рекурсии 
// (разбиение на части - управление вычислениями - ускорение вычислений!)
long RecPow(int numA, int numB)
{
  if (numB == 2) return numA * numA;
  if (numB == 1) return numA;
  if (numB % 2 == 0) return RecPow(numA, numB/2) * RecPow(numA, numB/2);
  else return RecPow(numA, numB/2) * RecPow(numA, numB/2+1);
}

// метод выводит ответ пользователю
void PrintData(string msg)
{
  Console.WriteLine(msg);
}

int numberA = ReadData("Введите число A: ");
int numberB = ReadData("Введите число B: ");
// PrintData($"Число {numberA} в степени {numberB} = {RecPowSimple(numberA, numberB)}");
PrintData($"Число {numberA} в степени {numberB} = {RecPow(numberA, numberB)}");