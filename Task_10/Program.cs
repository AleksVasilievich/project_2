// Задача 10: Напишите программу, которая принимает на
// вход трёхзначное число и на выходе показывает вторую
// цифру этого числа.Примеры:456 -> 5 ,782 -> 8, 918 -> 1

int num = new Random().Next(100,1000);
Console.WriteLine($"Num = {num}");
//Console.Write("Введите трёхзначное число ->");
//int num = int.Parse(Console.ReadLine());
int num1 = num / 10 ;
int num2 = num1 % 10 ;
Console.Write("Вторая цифра числа -> " + num2);