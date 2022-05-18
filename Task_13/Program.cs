// // Задача 13: Напишите программу, которая выводит
// третью цифру заданного числа или сообщает, что третьей  цифры нет.
// Примеры:645 -> 5,   78 -> третьей цифры нет,   32679 -> 6

Console.Write("Введите число ->");
int num = int.Parse(Console.ReadLine());
string numText = Convert.ToString(num);
if (numText.Length > 2)
{
    Console.Write(" третья цифра -> " + numText[2]);
}
else
{
    Console.Write(" -> третьей  цифры нет ");
}
