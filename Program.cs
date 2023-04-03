using System;
using static System.Console;

Write("Введите элементы массива через пробел: ");
string[] array = ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
Write("Массив содержащий не более 3-х символов состоит из следующих элементов: ");
ArrayWithThreeSimbols(array);

void ArrayWithThreeSimbols(string[] array)
{
Write("[");
for (int i = 0; i < array.Length; i++)
{
    if (array[i].Length <= 3)
    {
        Write($"{array[i]} ");
    }
}
Write("]");
}