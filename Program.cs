using System;
using static System.Console;

Write("Введите элементы массива через пробел: ");
string[] array = ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
NewArray(array);
Write("Массив содержащий не более 3-х символов состоит из следующих элементов: ");
PrintArray(array);

// Write("Введите второй элемент исходного массива: ");
// string[] array2 = ReadLine().Split(" ",StringSplitOptions.RemoveEmptyEntries);
// Write("Введите третий элемент исходного массива: ");
// string[] array3 = ReadLine().Split(" ",StringSplitOptions.RemoveEmptyEntries);

// string[] inArray = {"Denmark","Hel","2"};



// if (inArray[0].Length <= 3) {WriteLine(inArray[0]);}
// if (inArray[1].Length <= 3) {WriteLine(inArray[1]);}
// if (inArray[2].Length <= 3) {WriteLine(inArray[2]);}
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



// string[] NewArray(string[] array)
// {
//     string[] result = new string[array.Length];
//     for (int i = 0; i < array.Length; i++)
//     {
//         if (array[i].Length <= 3)
//         {
//             for (int j = 0; j <= i; j++)
//             {
//                 result[j] = array[i];
//             }
//         }
//     }
//     return result;
// }

void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Write($"{array[i]} , ");
    }
}