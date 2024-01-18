int MinDigit(int a)
{
    int b, c;
    b = a % 10;
    for (int i = a; i > 0; i /= 10)
    {
        c = i % 10;
        if (c < b)
            b = c;
    }
    return b;
}
int MaxDigit(int a)
{
    int b, c;
    b = a % 10;
    for (int i = a; i > 0; i /= 10)
    {
        c = i % 10;
        if (c > b)
            b = c;
    }
    return b;
}
int a = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine(MinDigit(a) + " + " + MaxDigit(a) + " = " + (MinDigit(a) + MaxDigit(a)));
