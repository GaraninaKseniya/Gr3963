// Задача №19 
// Напишите программу, которая принимает на вход пятизначное число 
// и проверяет, является ли оно палиндромом.

// метод читает данные от пользователя
int ReadData(string msg)
{
  Console.WriteLine(msg);
  return int.Parse(Console.ReadLine() ?? "0");
}

// метод проверки 5-значного числа на палиндром
bool PalinTest(int num)
{
  bool res = false;
  if ((num / 10000 % 10 == num % 10) && (num / 1000 % 10 == num / 10 % 10))
  {
    res = true;
    Console.WriteLine("Введенное число является палиндромом");
  }
  else
  {
    Console.WriteLine("Введенное число не является палиндромом");
  }
  return res;
}

// void PalinTest(int num)
// {
//   char[] array = (Console.ReadLine() ?? "0").ToString().ToCharArray();
//   if (array.Length == 5)
//   {
//     if ((num / 10000 % 10 == num % 10) && (num / 1000 % 10 == num / 10 % 10))
//     {
//       Console.WriteLine("Введенное число является палиндромом");
//     }
//     else
//     {
//       Console.WriteLine("Введенное число не является палиндромом");
//     }
//   }
//   else
//   {
//    Console.WriteLine("Введено не пятизначное число"); 
//   }
// }

int num = ReadData("Введите пятизначное число: ");
PalinTest(num);