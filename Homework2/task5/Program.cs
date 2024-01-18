void Swap(ref int a, ref int b)
{
    int c = 0;
    c = b;
    b = a;
    a = c;
}
System.Console.WriteLine("a: ");
int a = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("b: ");
int b = Convert.ToInt32(Console.ReadLine());
Swap(ref a, ref b);
System.Console.Write("a = ");
System.Console.WriteLine(a);
System.Console.Write("b = ");
System.Console.WriteLine(b);
