
int Pow(int A,int B)
{     
    int n=1;
    int result = 1;
    while(n<=B)
    {
        result=result*A;
        n++;
    }
    return result;
}

Console.WriteLine("Введите число которое нужно возвести в степень");
int.TryParse(Console.ReadLine(), out int A);
Console.WriteLine("Введите степень в которую нужно возвести число");
int.TryParse(Console.ReadLine(), out int B);


int result= Pow(A,B);
Console.WriteLine($"Результат возведения числа A в степень B: {result}");