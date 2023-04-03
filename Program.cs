using System;
using static System.Console;

Write("Введите элементы массива через пробел: ");
string[] array = ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
Write("Массив содержащий не более 3-х символов состоит из следующих элементов: ");

Write("[");
for (int i = 0; i < array.Length; i++)
{
    if (array[i].Length <= 3)
    {
        Write($"{array[i]} ");
    }
}
Write("]");

// Write("[");
// if (array[0].Length <= 3) {Write(array[0]);}
// if (array[1].Length <= 3) {Write(array[1]); Write(",");}
// if (array[2].Length <= 3) {Write(array[2]); Write(",");}
// if (array[3].Length <= 3) {Write(array[3]); Write(",");}
// if (array[4].Length <= 3) {Write(array[4]); Write("]");}

string[] NewArray(string[] array)
{
    string[] result = new string[array.Length];
    int i = 0;
    while (i < array.Length)
    {
        if (array[i].Length <= 3)
        {
            result[i] = array[i];
            i++;
        }
        else
        {
            i++;
        }
    }
    return result;
}

void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Write($"{array[i]} , ");
    }
}