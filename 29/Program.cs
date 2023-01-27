int[] Array()
{
    int[] arr = new int[8];
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = new Random().Next(-100,100);
        Console.Write($"[{arr[0]},{arr[1]},{arr[2]},{arr[3]},{arr[4]},{arr[5]},{arr[6]},{arr[7]}]");
    }
    return arr;
}


Console.Write(Array());


