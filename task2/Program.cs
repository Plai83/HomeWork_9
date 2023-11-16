// Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N с помощью рекурсии.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

int ReadInt(string msg)
{
    System.Console.WriteLine(msg);
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}

int GettingSumNumbers(int M, int N)
{
    if(M > N)
    {
        return 0;
    }
    return GettingSumNumbers(M + 1, N) + M;
}

int M = ReadInt("Введите начальное число");
int N = ReadInt("Введите конечное число");

Console.WriteLine(GettingSumNumbers(M, N));