 void Divisors(int x)
 {
    for (int i = 1; i <= x; i++)
    {
        if (x % i == 0)
        System.Console.Write(i + " ");
    }
 }
 int a = Convert.ToInt32(Console.ReadLine());
 Divisors(a);
 