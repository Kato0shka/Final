// Задача: Написать программу, которая из массива строк формирует массив из строк, длина которых меньше либо равна 3 символа.

int n = 4;
Console.WriteLine($"В изначальном массиве {n} элементов");

string[] array = new string[n];
array[0] = "1234";
array[1] = "1567";
array[2] = "-2";
array[3] = "computer science";

void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
}

Console.WriteLine($"Изначальный массив:");
PrintArray(array);

string[] arrayLessThanThree(string[] array)
{
    int lengthNewArray = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3) lengthNewArray++;
    }

    string[] newArray = new string[lengthNewArray];

    int index = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
        {
            newArray[index] = array[i];
            index++;
        }
    }
    return newArray;

}

Console.WriteLine();
Console.WriteLine($"Новый массив:");
PrintArray(arrayLessThanThree(array));