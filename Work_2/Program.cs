// Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

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
}

int SumNegativeIndex(int[] array)
{
    int sum = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (i % 2 != 0)
        {
            sum += array[i];
        }
    }
    return sum;
}



int[] array = GetArray(6, -100, 100);
// SumNegativeIndex(array);
PrintMass(array);

Console.WriteLine($"");
Console.WriteLine($"{SumNegativeIndex(array)} ");