
using System;

string num = Convert.ToString(inputNumber(("Введите число: ")));

Console.WriteLine(numSumm(num));

int numSumm(string num)
{
    int result = 0;

    for (int i = 0; i < num.Length; i++)
    {
        result += Convert.ToInt32(Convert.ToString(num[i]));
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