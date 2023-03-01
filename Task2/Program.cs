// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму
//  натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30


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

int GetSumNumber(int numberM, int numberN, int sum)
{
    if (numberM > numberN) return sum;
    else 
    {
        sum+=numberM;
    return GetSumNumber(numberM + 1, numberN, sum);
    }
}

int numberM = GetNumber("Введите число M:");
int numberN = GetNumber("Введите число N:");
int sum = 0;
Console.WriteLine(GetSumNumber(numberM, numberN, sum));
