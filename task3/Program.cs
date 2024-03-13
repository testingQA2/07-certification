// Задайте произвольный массив. Выведете его элементы, начиная с конца. Использовать рекурсию, не использовать циклы.


int[] numbers = new int[] { 1, 56, 9, 4, 2, 5, 31, 67, 9, 105, 22, 19 };

void PrintArray(int[] array, int index)
{
    if (index >= array.Length)
    {
        return;
    }
    else
    {
        PrintArray(array, index + 1);
        Console.Write(array[index] + " ");
    }
}

PrintArray(numbers,0);