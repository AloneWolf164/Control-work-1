using System;
using static System.Console;

// Write("Введите первый элемент исходного массива: ");
// string[] array1 = ReadLine().Split(" ",StringSplitOptions.RemoveEmptyEntries);
// Write("Введите второй элемент исходного массива: ");
// string[] array2 = ReadLine().Split(" ",StringSplitOptions.RemoveEmptyEntries);
// Write("Введите третий элемент исходного массива: ");
// string[] array3 = ReadLine().Split(" ",StringSplitOptions.RemoveEmptyEntries);

string[] inArray = {"Denmark","Hel","2"};
// string[] array1 = inArray[0].Split(" ",StringSplitOptions.RemoveEmptyEntries);
// string[] array2 = inArray[1].Split(" ",StringSplitOptions.RemoveEmptyEntries);
// string[] array3 = inArray[2].Split(" ",StringSplitOptions.RemoveEmptyEntries);

if (inArray[0].Length <= 3) {WriteLine(inArray[0]);}
if (inArray[1].Length <= 3) {WriteLine(inArray[1]);}
if (inArray[2].Length <= 3) {WriteLine(inArray[2]);}
