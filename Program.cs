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

int[] CreateArray(int size)
{
    int[] array = new int[size];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(1, 101);
    }
    return array;
}

Console.Write("Введите число: ");
int N = Convert.ToInt32 (Console.ReadLine());
int[] res = CreateArray(N);
Console.WriteLine($"Массив: [{string.Join(";", res)}]");