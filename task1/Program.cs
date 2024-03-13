// Задайте значения M и N. 
//Напишите программу, которая выведет все натуральные числа в промежутке от M до N. 
//Использовать рекурсию, не использовать циклы.


// Считываем введенные значения
int ReadInt(string msg)
{
    Console.WriteLine(msg);
    return Convert.ToInt32(Console.ReadLine());
}

// Определяем большее число
int BiggerOne(int M, int N)
{
    if (M > N)
    {
        return M;
    }
    else
        return N;
}

// Определяем меньшее число
int SmallerOne(int M, int N)
{
    if (M < N)
    {
        return M;
    }
    else
        return N;
}


//печатаем от меньшего к большему

void PrintNumbers(int M, int N)
{
    if (SmallerOne(M, N) >= BiggerOne(M, N))
    {
        Console.WriteLine(SmallerOne(M, N) + " ");
        return;
    }
    PrintNumbers((BiggerOne(M, N) - 1), SmallerOne(M, N));
    Console.WriteLine(BiggerOne(M, N) + " ");
}

int N = ReadInt("Enter N");
int M = ReadInt("Enter M");
System.Console.WriteLine();
PrintNumbers(N, M);