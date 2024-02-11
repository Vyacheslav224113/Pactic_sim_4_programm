// методы(функции) бывают 2х типо 1 void(не возвращает значение), 2. возвращают значение(return)

// Тип_метода ИмяМетода (пар1, пар2, ... парN)
// a, b, - 2 числа, sign - знак арифметической операции
int Calculate(int a, int b, string sign)
{
    if(sign == "+")
    {
        return a + b; // сумма
    }
    else if(sign == "-")
    {
        return a - b;
    }
    else if(sign == "*")
    {
        return a * b;
    }
    else if(sign == "/")
    {
        return a / b;
    }
    else
    {
        Console.WriteLine("Введен неизвестный знак арифм. операции");
        return 0;
    }
}

// Вызов метода
Console.WriteLine(Calculate(2, 3, "+"));
Console.WriteLine(Calculate(2, 3, "-"));
Console.WriteLine(Calculate(2, 3, "*"));
Console.WriteLine(Calculate(2, 3, "/"));
Console.WriteLine(Calculate(2, 3, "."));