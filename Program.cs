Console.WriteLine("  Enter The start number");
int num1 = int.Parse(Console.ReadLine());
Console.WriteLine("  Enter The end number");
int num2 = int.Parse(Console.ReadLine());
Console.WriteLine("  Prime numbers from {0} to {1} is :", num1, num2);
for (int i = num1; i <= num2; i++)
{
    int sum = 0;
    for (int j = 1; j <= i; j++)
    {
        if (i % j == 0)
            sum++;
    }
    if (sum == 2)
        Console.WriteLine(" " + i);
}