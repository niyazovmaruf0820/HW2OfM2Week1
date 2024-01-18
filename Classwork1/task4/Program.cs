void PrintStars(int n)
{
    for (int i = 0; i < n; i++)
    {
        System.Console.Write("*");
    }
}
PrintSpaces(10);
PrintStars(10);
void PrintSpaces(int n)
{
    for (int i = 0; i < n; i++)
    {
        System.Console.Write(" ");
    }
}
PrintSpaces(10);
PrintStars(10);
System.Console.WriteLine();
void PrintRightTriangle(int size)
{
    for (int i = 1, j = size - 1; i <= size; i++, j--)
    {
        PrintSpaces(size - i);
        PrintStars(size - j);
        System.Console.WriteLine();
    }
}
PrintRightTriangle(4);
System.Console.WriteLine();
void Tree(int size)
{
    for (int i = 1; i <= size; i++)
    {
        PrintSpaces(size - i);
        PrintStars(2 * i - 1);
        Console.WriteLine();
    }
    for (int i = 0; i < 2; i++)
    {
        PrintSpaces(size - 2);
        PrintStars(3);
        Console.WriteLine();
    }

}
Tree(4);