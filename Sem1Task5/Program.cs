// Задача №5
// Напишите программу, которая на вход принимает одно число (N), 
// а на выходе показывает все целые числа в промежутке от -N до N.

Console.Write("Введите число: ");
string? lineNum = Console.ReadLine();
if (lineNum != null)
{
  int num = int.Parse(lineNum);
  string res = string.Empty;
  int negNum = num * (-1);
  
  while (negNum <= num)
  {
    res = res + negNum + "\t";
    negNum++;
  }
  
// while (negNum < num)
//   {
//     res = res + negNum + ", ";
//     negNum++;
//   }
//   res = res + num;
 
  Console.WriteLine(res);
}