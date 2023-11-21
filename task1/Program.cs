// Задайте значения M и N. Напишите программу, которая выведет все чётные натуральные числа в промежутке от M до N с помощью рекурсии.
// M = 1; N = 5 -> "2, 4"
// M = 4; N = 8 -> "4, 6, 8"

int ReadInt(string msg)
{
    System.Console.WriteLine(msg);
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}

void PrintResult(int M, int N)
{
    if(M > N)
    {
        return;
    }
        if(M%2 ==0)
    {
        System.Console.Write($"{M}");
        if(M < N - 1) System.Console.Write(",\t");
    }
    PrintResult(M + 1, N);
}


int M = ReadInt("Введите начальное число");
int N = ReadInt("Введите конечное число");

PrintResult(M, N);
