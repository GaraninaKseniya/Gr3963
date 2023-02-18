// Задача №11
// Напишите программу, которая выводит случайное трёхзначное число 
// и удаляет вторую цифру этого числа. 

System.Random numSintezator = new System.Random();

int rndNumber = numSintezator.Next(100, 1000);
Console.WriteLine(rndNumber);
// int firstNum = rndNumber / 100;
// int lastNum = rndNumber % 10;
// int num = firstNum*10 + lastNum;
// Console.WriteLine(num);
Console.WriteLine(rndNumber / 100 * 10 + rndNumber % 10);
// вариант 2
char[] digits = rndNumber.ToString().ToCharArray();
Console.WriteLine(int.Parse((digits[0]).ToString())*10+int.Parse((digits[2]).ToString()));