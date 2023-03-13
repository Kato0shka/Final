// Задача: Написать программу, которая из массива строк формирует массив из строк, длина которых меньше либо равна 3 символа.

int n = 4;
Console.WriteLine($"В изначальном массиве {n} элементов");

string[] array = new string[n];
array[0] = "hello";
array[1] = "2";
array[2] = "world";
array[3] = ":-)";

void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
}

Console.WriteLine($"Изначальный массив:");
PrintArray(array);