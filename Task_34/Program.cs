// Задача 34: Задайте массив заполненный случайными
// положительными трёхзначными числами. Напишите
// программу, которая покажет количество чётных чисел в
// массиве.   [345, 897, 568, 234] -> 2

Console.Write("Введите размер массива -> ");
int size = int.Parse(Console.ReadLine());
int[] nums = new int[size];
int sum = 0;

var newRnd = new Random();
for (int i = 0; i < size; i++)
{
    nums[i] = newRnd.Next(0, 10);
    Console.WriteLine(nums[i] + " ");
}
for (int i = 0; i < size; i++)
{
    
    if(nums[i] %2 == 0) sum += i;
}
Console.WriteLine($" Количество чётных чисел = {sum}");