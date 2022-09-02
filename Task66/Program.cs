/*
Задача 66: Задайте значения M и N. Напишите программу, которая 
найдёт сумму натуральных элементов в промежутке от M до N.
M = 1; N = 15 -> 120
M = 4; N = 8. -> 30
*/

using static System.Console;
WriteLine(GetSumInInterval(Input("M"), Input("N")));

int Input(string text)
{
    WriteLine($"Введите значение числа {text}: ");
    int number = int.Parse(ReadLine()!);
    return number;
}

int GetSumInInterval(int a, int b)
{
    if (a == b) return a;//или b не важно
    else if (a > b) return b + GetSumInInterval(a, b + 1);
    return a + GetSumInInterval(a + 1, b);
}

