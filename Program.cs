// Конспекты с семинара от 26.11: https://gb.ru/lessons/383956

/* Задайте массив. Напишите программу, которая определяет,
присутствует ли заданное число в массиве. Программа
должна выдать ответ: Да/Нет.
Примеры
[1 3 4 19 3], 8 => Нет
[-4 3 4 1], 3 => Да */

/* Console.Clear();
Console.Write("Введите длину массива: ");
int x = Convert.ToInt32(Console.ReadLine());
int[] array = new int[x];
for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().next(1,11);
}

Console.WriteLine(string.Join(", ", array)); 

int k = new Random().next(1,11);
Console.WriteLine(k);
bool flag = false;
for (int i = 0; i < array.Length; i++)
{
    if(array[i] == k){
        flag = true;
        Console.WriteLine(flag);
        break;
    }
}
if(flag == false){
Console.WriteLine(flag);
} */

/* Задайте массив из 10 элементов, заполненный числами из
промежутка [-10, 10]. Замените отрицательные элементы на
положительные, а положительные на отрицательные.
Пример
[1 -5 6]
=> [-1 5 -6] */

/* Console.Clear();
int[] array = new int[10];
for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().next(-10,11);
}
Console.WriteLine(string.Join(", ", array)); 

for (int i = 0; i < array.Length; i++)
{
    array[i] = -array[i];
}
Console.WriteLine(string.Join(", ", array)); */

/* Найдите произведения пар чисел в одномерном массиве. Парой
считаем первый и последний элемент, второй и предпоследний и
т.д. Результат запишите в новый массив.
Пример
[1 3 2 4 2 3] => [3 6 8]
[2 3 1 7 5 6 3] => [6 18 5] (элемент 7 не имеет пары) */

/* Console.Clear();
Console.Write("Введите длину массива: ");
int x = Convert.ToInt32(Console.ReadLine());
int[] array = new int[x];
int[] new_array = new int[array.Length / 2];
for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().next(1, 11);
}
Console.WriteLine(string.Join(", ", array));
for (int i = 0; i < array.Length / 2; i++)
{
    new_array[i] = array[i] * array[array.Length - 1 - i];
}
Console.WriteLine(string.Join(", ", new_array)); */

/* Дано натуральное трёхзначное число. Создайте массив, состоящий из
цифр этого числа. Младший разряд числа должен располагаться на 0-
м индексе массива, старший – на 2-м.
Пример
456 => [6 5 4]
781 => [1 8 7] */

// Решение 1

/* Console.Clear();
Console.Write("Введите натуральное число N: ");
int N = Convert.ToInt32(Console.ReadLine());
if (N < 10)
{
    Console.WriteLine(N);
}
else
{
    while (N > 0)
    {
        int currentDigit = N % 10;
        N /= 10;
        if (N > 0)
        {
            Console.Write(currentDigit + " ");
        }
        else
        {
            Console.WriteLine(currentDigit);
        }
    }
} */

// Решение 2

/* Console.Clear();
int[] array = new int[3];
Random random = new Random();
int numbers = random.Next(100,999);

Console.WriteLine(numbers);
for (int i = 0; i < array.Length; i++)
{
    array[i] = numbers%10;
    numbers /= 10;
}

Console.WriteLine(string.Join(" ", array)); */

