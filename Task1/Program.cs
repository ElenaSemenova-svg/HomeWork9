//Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные
// числа в промежутке от N до 1. Выполнить с помощью рекурсии.
//N = 5 -> "5, 4, 3, 2, 1"
//N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

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

string GetNaturalNumber(int number)
{
    if (number == 1) return "1";
    else return number.ToString() + " " + GetNaturalNumber(number - 1);
}

int number = GetNumber("Введите число");
Console.WriteLine(GetNaturalNumber(number));