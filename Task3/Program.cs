﻿// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29



int GetNumber(string message)
{
    int result = 0;
    while (true)
    {
        Console.WriteLine(message);
        if (int.TryParse(Console.ReadLine(), out result) && result >= 0)
        {
            break;
        }
        else
        {
            Console.WriteLine("Вы ввели некорректное число! Повтороите ввод");
        }
    }
    return result;
}

int GetAkkermanFunction(int numberM, int numberN)
{
    if (numberM == 0) return numberN + 1;
    else if (numberM > 0 && numberN == 0)
        return GetAkkermanFunction(numberM - 1, 1);
    else return GetAkkermanFunction(numberM - 1, GetAkkermanFunction(numberM, numberN - 1));

}

int numberM = GetNumber("Введите число M:");
int numberN = GetNumber("Введите число N:");
Console.WriteLine();
Console.WriteLine($"Функция Аккермана равна {GetAkkermanFunction(numberM, numberN)} двух чисел {numberM} и {numberN}");
