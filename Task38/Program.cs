Console.WriteLine("Введите размер массива: ");
int size = Convert.ToInt32(Console.ReadLine());
double[] array = new double[size];
void FillArray(double[] collection)
{
    for (int i = 0; i < collection.Length; i++)
    {
        collection[i] = new Random().Next(1, 100) + new Random().NextDouble();
    }
}
void PrintArray(double[] col)
{
    for (int i = 0; i < col.Length; i++)
    {
        Console.Write($"{Math.Round(col[i], 2)} ");
    }
}
double DifferenceNumber(double[] collect)
{
    double max = collect[0];
    double min = collect[0];
    for (int i = 0; i < collect.Length; i++)
    {
        if (collect[i] > max)
        {
            max = collect[i];
        }
    }
    for (int i = 0; i < collect.Length; i++)
    {
        if (collect[i] < min)
        {
            min = collect[i];
        }
    }
    double diff = max - min;
    return diff;
}

FillArray(array);
PrintArray(array);
double d = DifferenceNumber(array);
Console.WriteLine();
Console.WriteLine(Math.Round(d, 2));