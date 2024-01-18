int a = Convert.ToInt32(Console.ReadLine());
int EvenCount(int n)
{
    int e = 0;
    for (int i = a; i > 0; i /= 10)
    {
        if ((i % 10) % 2 == 0) e++;
    }
    return e;
}
int OddCount(int n)
{
    int o = 0;
    for (int i = a; i > 0; i /= 10)
    {

        if ((i % 10) % 2 != 0) o++;

    }
    return o;
}
int DigitCount(int n)
{
    int d = 0;
    for (int i = a; i > 0; i /= 10)
    {
        d++;
    }
    return d;
}
int SumDigit(int n)
{
    int s = 0;
    for (int i = a; i > 0; i /= 10)
    {
        s += i % 10;
    }
    return s;
}

System.Console.WriteLine("Even:" + EvenCount(a));
System.Console.WriteLine("Odd:" + OddCount(a));
System.Console.WriteLine("Digit:" + DigitCount(a));
System.Console.WriteLine("Sum:" + SumDigit(a));
