int Summ(int n)
{

    int result = 0;
    while (n >= 1)
    {
        result = result + (n%10);
        n = n / 10;
    }
    return result;
}
int.TryParse(Console.ReadLine(), out int n);
if(n<0)
{
    Console.WriteLine("Число должно быть положительным");
    return;
}

Console.WriteLine(Summ(n));