int a = Convert.ToInt32(Console.ReadLine());
int b = Convert.ToInt32(Console.ReadLine());
int Add(int a, int b)
{
    return a + b;
}
int Substract(int a, int b)
{
    return a - b;
}
int Multipy(int a, int b)
{
    return a * b;
}
int Division(int a, int b)
{
    return a / b;
}

System.Console.WriteLine("Add:" + Add(a, b));
System.Console.WriteLine("Substract:" + Substract(a, b));
System.Console.WriteLine("Multipy:" + Multipy(a, b));
System.Console.WriteLine("Division:" + Division(a, b));
