// Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

int ReadInt(string msg)
{
    while(true)
    {
    System.Console.WriteLine(msg);
    int number = Convert.ToInt32(Console.ReadLine());
    if(number < 0)
    {
        System.Console.WriteLine("Число должно быть больше или равно 0 !");
        continue;
    }
    return number;
    }
}
int formulaAck(int m, int n)
{   if(m == 0) return n + 1;
    else if(n == 0) return formulaAck(m - 1, 1);
    else return formulaAck(m - 1, formulaAck(m, n - 1));
}

int m = ReadInt("Введите первое число");
int n = ReadInt("Введите второе число");
Console.WriteLine(formulaAck(m, n));