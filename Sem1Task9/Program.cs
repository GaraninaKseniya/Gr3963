﻿// Задача №9
// Напишите программу, которая выводит случайное число из 
// отрезка [10, 99] и показывает наибольшую цифру числа. 

System.Random numSintezator = new System.Random();

// вариант 1
int rndNumber = numSintezator.Next(10, 100);
Console.WriteLine(rndNumber);
int firstNum = rndNumber / 10;
int secondNum = rndNumber % 10;
if (firstNum > secondNum)
{
  Console.WriteLine(firstNum);
}
else
{
  Console.WriteLine(secondNum);
}

// вариант 2
char[] digits = numSintezator.Next(10, 100).ToString().ToCharArray();
Console.WriteLine(digits);
int firstNumber = ((int)digits[0]) - 48;
int secondNumber = ((int)digits[1]) - 48;
// <переменная> = (условие)?<значение1>:<значение2>;
// if (условие)
// {
//   <переменная> = <значение1>;
// }
// else
// {
//   <переменная> = <значение2>;
// }
// тернарный оператор:
int resultNumber = (firstNumber>secondNumber)?resultNumber=firstNumber:resultNumber=secondNumber;
Console.WriteLine(resultNumber);