void FillArray(int[] collection)// Заполнение массива
{
    int length = collection.Length;
    int index = 0;
    while (index < length)
    {
       collection[index] = new Random().Next(1, 10);
        //index = index + 1;
        index++;
    }
}

void PrintArray(int[] col)// Печать массива
{
    int count = col.Lenght;
    int position = 0;
    while (position < count)
    {
        Console.Writeline(col[position]);
        position++;
    }
}

int[] array = new int[10];

FillArray(array);
PrintArray(array);