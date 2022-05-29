Console.WriteLine("Введите размер массива: ");
int size = Convert.ToInt32(Console.ReadLine());
int[] array = new int[size];
void FillArray(int[] collection)
{
    for (int i = 0; i < collection.Length; i++)
    {
        collection[i] = new Random().Next(-99, 100);
    }
}
void PrintArray(int[] col)
{
    for (int i = 0; i < col.Length; i++)
    {
        Console.Write($"{col[i]} ");
    }
}
int SumNumber(int[] collect)
{
    int sum = 0;
    for (int i = 0; i < collect.Length; i++)
    {
        if (i % 2 == 1)
        {
            sum = sum + collect[i];
        }
    }
    return sum;
}

FillArray(array);
PrintArray(array);
int s = SumNumber(array);
Console.WriteLine();
Console.WriteLine(s);