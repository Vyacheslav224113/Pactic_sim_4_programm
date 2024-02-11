// методы(функции) бывают 2х типо 1 void(не возвращает значение), 2. возвращают значение(return)

// Тип_метода ИмяМетода (пар1, пар2, ... парN)
// a, b, - 2 числа, sign - знак арифметической операции
// int Calculate(int a, int b, string sign)
// {
//     if(sign == "+")
//     {
//         return a + b; // сумма
//     }
//     else if(sign == "-")
//     {
//         return a - b;
//     }
//     else if(sign == "*")
//     {
//         return a * b;
//     }
//     else if(sign == "/")
//     {
//         return a / b;
//     }
//     else
//     {
//         Console.WriteLine("Введен неизвестный знак арифм. операции");
//         return 0;
//     }
// }

// // Вызов метода
// Console.WriteLine(Calculate(6, 58, "+"));
// Console.WriteLine(Calculate(13, 5, "-"));
// Console.WriteLine(Calculate(14, 62, "*"));
// Console.WriteLine(Calculate(1535, 45, "/"));
// Console.WriteLine(Calculate(2, 3, "."));




// Задание 1. Совместная работа
// Задайте одномерный массив, заполненный случайными
// числами. Определите количество простых чисел в этом
// массиве.

// int[] CreateArray(int size)
// {
//     int[] array = new int[size];
//     for (int i = 0; i < array.Length; i++)
//     {
//         array[i] = new Random().Next(1, 101);
//     }
//     return array;
// }

// Console.Write("Введите число: ");
// int N = Convert.ToInt32 (Console.ReadLine());
// int[] res = CreateArray(N);
// Console.WriteLine($"Массив: [{string.Join(";", res)}]");


// Задание 2. Работа в сессионных залах
// Задайте массив из N случайных целых чисел (N вводится с
// клавиатуры).
// Найдите количество чисел, которые оканчиваются на 1 и
// делятся нацело на 7.

int[] CreateArray(int size)
{
    int[] array = new int[size];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(1, 101);
    }
    return array;
}
int GetCount(int[] arr)
{
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if(arr[i] % 7 == 0 && arr[i] % 10 == 1)
        {
            count++;
        }
    }
    return count;
}

Console.Write("Введите число: ");
int N = Convert.ToInt32 (Console.ReadLine());
int[] res = CreateArray(N);
Console.WriteLine($"Массив: [{string.Join(";", res)}]");
Console.WriteLine($"Результат: {GetCount(res)}");