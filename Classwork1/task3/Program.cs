void PrintStars(int n)
{
    for (int i = 0; i < n; i++)
    {
        System.Console.Write("*");
    }
}
void PrintSquare(int size)
{
    for (int i = 0; i < size; i++)
    {
        PrintStars(size);
        System.Console.WriteLine();
    }
}
void PrintRectangle(int width, int height)
{
    for (int i = 0; i < height; i++)
    {
        PrintStars(width);
        System.Console.WriteLine();
    }
}
void PrintTriangle(int size)
{
    for (int i = size - 1; i >= 0; i--)
    {
        PrintStars(size - i);
        System.Console.WriteLine();
    }
}
PrintTriangle(4);
