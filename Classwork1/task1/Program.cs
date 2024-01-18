void PrintFromNumberToOne(int number)
{
    for (int i = number; i > 0; i--)
    {
        System.Console.Write(i + " ");
    }
}
int a = Convert.ToInt32(Console.ReadLine());
PrintFromNumberToOne(a);