
using System;

int num1 = inputNumber(("Введите первое число: "));
int num2 = inputNumber(("Введите второе число: "));

System.Console.WriteLine(stepenQube(num1, num2));

int stepenQube(int num1, int num2)
{
    int result = 1;
    for (int i = 1; i <= num2; i++)
    {
        result *= num1;
    }
    return result;
}


int inputNumber(string message)
{
    int number;
    string text;

    while (true)
    {
        Console.Write(message);
        text = Console.ReadLine();
        if (int.TryParse(text, out number))
        {
            break;
        }
        Console.WriteLine("Не удалось распознать число, попробуйте еще раз.");
    }
    return number;
}