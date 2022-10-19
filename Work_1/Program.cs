// Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

Console.Clear();

int[] GetArray(int size, int minValue, int maxValue)
{
    int[] res = new int[size];
    for (int i = 0; i < size; i++)
    {
        res[i] = new Random().Next(minValue, maxValue + 1);
        // Console.Write($"{res[i]} ");
    }
    return res;
}

void PrintMass(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

int SearchPositiveNumbers(int[] array)
{
    int count = 0;
    foreach (int el in array)
    {
        if (el % 2 == 0)
        {
            count++;
        }
    }
    return count;
}

int[] array = GetArray(12, 100, 1000);
// SearchPositiveNumbers(array);
PrintMass(array);
Console.WriteLine($"{SearchPositiveNumbers(array)} ");