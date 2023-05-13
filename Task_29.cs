//Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
using System;

int num = inputNumber(("Введите число: "));

Console.WriteLine("[" + string.Join( ", ", createArray(num)) + "]");

int[] createArray(int num)
{
    Random rand = new Random();
    int[] array = new int[num];

    for (int i = 0; i < num; i++)
    {
        array[i] = rand.Next(0,9);
    }
    return array;
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
