// Задача 15: 
// Напишите программу, которая принимает на вход цифру, 
// обозначающую день недели, и проверяет, является ли этот день выходным.

Console.Write("Введите день недели: ");
int num = int.Parse(Console.ReadLine() ?? "0");
if (num > 0 && num < 8)
{
  if (num > 0 && num < 6)
  {
    Console.WriteLine("Это рабочий день.");
  }
  else
  {
    Console.WriteLine("Ура, выходной!");
  }
}
else
{
  Console.WriteLine("Это не день недели.");
}

Dictionary<int, string> daysOfWeek = new Dictionary<int, string>();
// добавляем дни недели в словарь
daysOfWeek.Add(1, "Понедельник, будний день");
daysOfWeek.Add(2, "Вторник, будний день");
daysOfWeek.Add(3, "Среда, будний день");
daysOfWeek.Add(4, "Четверг, будний день");
daysOfWeek.Add(5, "Пятница, будний день");
daysOfWeek.Add(6, "Суббота, выходной");
daysOfWeek.Add(7, "Воскресенье, выходной");
// просим ввести день недели
Console.Write("Введите день недели (1-7): ");
int dayOfWeek = int.Parse(Console.ReadLine() ?? "0");
if (daysOfWeek.ContainsKey(dayOfWeek))
{
  Console.WriteLine(daysOfWeek[dayOfWeek]);
}
else
{
  Console.WriteLine("Это не день недели.");
}