//Задача 32: Напишите программу замена элементов массива: положительные элементы замените на соответствующие отрицательные, и 
//Задача 33: Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве.
//4; массив [6, 7, 19, 345, 3] -> нет
//3; массив [6, 7, 19, 345, 3] -> да

/*void PrintArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}

void FillArrayRandomNumbers(int[] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(-9, 10);
    }
}

int[] array = new int[12];
int sumPositive = 0;
int sumNegative = 0;

FillArrayRandomNumbers(array);
PrintArray(array);

for(int i = 0; i < array.Length; i++)
{
    if(array[i] > 0)
        sumPositive += array[i];
    else
        sumNegative += array[i];
}
Console.WriteLine($"Сумма положительных = {sumPositive}, сумма отрицательных = {sumNegative}");


bool SearchNumber(int[] array, int number)
{
    for(int i = 0; i < array.Length; i++)
    {
        if(array[i] == number)
            return true;
    }
    return false;
}*/

/*Задача 35: Задайте одномерный массив из 123 случайных чисел. Найдите количество элементов массива, значения которых лежат в отрезке [10,99]. 
Пример для массива из 5, а не 123 элементов. В своём решении сделайте для 123
[5, 18, 123, 6, 2] -> 1
Задача 37: Найдите произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент, второй и предпоследний и т.д. Результат запишите в новом массиве.
[1 2 3 4 5] -> 5 8 3
[6 7 3 6] -> 36 21*/

void PrintArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}

int SearchNumbers(int[] array, int leftside, int rightside)
{
    int count = 0;
    for(int i = 0; i < array.Length; i++)
    {
        if(leftside <= array[i]  &  array[i] <= rightside)
            {
                count++;
            }
    }
    return count;
}

void FillArrayRandomNumbers(int[] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(0, 124);
    }
}

Console.Write("Input length array: ");
int length = Convert.ToInt32(Console.ReadLine());
Console.Write("Input leftside: ");
int leftside = Convert.ToInt32(Console.ReadLine());
Console.Write("Input rightside: ");
int rightside = Convert.ToInt32(Console.ReadLine());
int[] array = new int[length];
FillArrayRandomNumbers(array);
int count = SearchNumbers(array, leftside, rightside);
PrintArray(array);
Console.Write($"Number to {leftside} from {rightside} = {count}");