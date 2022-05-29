Console.WriteLine("Введите размер массива: ");
int size = Convert.ToInt32(Console.ReadLine());
int[] array = new int[size];
void FillArray(int[] collection)
{
    for (int i = 0; i < collection.Length; i++)
    {
        collection[i] = new Random().Next(100, 1000);
    }
}
void PrintArray(int[] col)
{
    for (int i = 0; i < col.Length; i++)
    {
        Console.Write($"{col[i]} ");
    }
}
int EvenNumber(int[] collect)
{
    int count = 0;
    for (int i = 0; i < collect.Length; i++)
    {
        if (collect[i] % 2 == 0)
        {
            count = count + 1;
        }
    }
    return count;
}

FillArray(array);
PrintArray(array);
int even = EvenNumber(array);
Console.WriteLine();
Console.WriteLine(even);