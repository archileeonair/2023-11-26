// Задача 1: Задайте одномерный массив из 10 целых чисел от 1 до 100. Найдите количество элементов массива, значения которых лежат в отрезке [20,90].

/* Console.Clear();
int[] array = new int[10];
int x = 0;
for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(1, 101);
}
Console.WriteLine(string.Join(", ", array));

for (int i = 0; i < array.Length; i++)
{
    if (array[i] <= 90 && array[i] >= 20)
    {
        x++;
    }
}
Console.WriteLine(x); */

// Задача 2: Задайте массив на 10 целых чисел. Напишите программу, которая определяет количество чётных чисел в массиве.

/* Console.Clear();
int[] array = new int[10];
int x = 0;
for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next();
}
Console.WriteLine(string.Join(", ", array));

for (int i = 0; i < array.Length; i++)
{
    if (array[i] % 2 == 0)
    {
        x++;
    }
}
Console.WriteLine(x); */

// Задача 3: Задайте массив из вещественных чисел с ненулевой дробной частью. Найдите разницу между максимальным и минимальным элементов массива.

/* Console.Clear();
double[] array = new double[5];
for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().NextDouble();
}
Console.WriteLine(string.Join(", ", array));

Console.WriteLine(array.Max());
Console.WriteLine(array.Min());

Console.WriteLine(array.Max() - array.Min()); */

// Задача 4**(не обязательно): Дано натуральное число в диапазоне от 1 до 100 000. Создайте массив, состоящий из цифр этого числа. Старший разряд числа должен располагаться на 0-м индексе массива, младший – на последнем. Размер массива должен быть равен количеству цифр.

using System.Buffers;

Console.Clear();
int x = new Random().Next(1, 100001);
Console.WriteLine(x);
int i = 0;
int j = 0;
int x_old = x;
while (x > 0)
{
    x = x / 10;
    j++;
}
Console.WriteLine(j);
int j_old = j;
x = x_old;
int[] array = new int[j];
while (x > 0)
{
    array[j-1] = x % 10;
    x = x / 10;
    j--;
}
Console.WriteLine(string.Join(", ", array));