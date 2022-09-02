/*
Задача 68: Напишите программу вычисления функции Аккермана 
с помощью рекурсии. Даны два неотрицательных числа m и n.
m = 2, n = 3 -> A(m,n) = 29
*/

using static System.Console;
WriteLine(AkkermanRec(Input("M"), Input("N")));

int Input(string text)
{
    int number = -1;
    while (number < 0)
    {
        WriteLine($"Введите неотрицательное число {text}: ");
        number = int.Parse(ReadLine()!);
    }
    return number;
}

int AkkermanRec(int a, int b)
{
    if (a == 0) return b + 1;
    else if (b == 0 && a != 0) return AkkermanRec(a - 1, 1);
    else if (a>0 && b>0) return AkkermanRec(a - 1, AkkermanRec(a, b - 1));
    else return AkkermanRec(a,b);
}
