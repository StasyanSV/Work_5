// Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

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

int DifMaxMin(int[] array)
{
    int min = array[0];
    int max = array[0];
    foreach (var el in array)
    {
        if (el > max)
        {
            max = el;
        }
        else 
        {
            if (el<min)
            {
                min = el;
            }
        }
    }
    // Console.WriteLine($"Min = {min}, Max = {max} ");
    int dif = max - min;
    return dif;
}


int[] array = GetArray(12, -100, 100);
PrintMass(array);
Console.WriteLine($"{DifMaxMin(array)} ");