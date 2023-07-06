class Sample
{
    public static void Main()
    {
        int[] arr1 = {1,2,3};
        string[] arr2 = {"Hello", "World"};
        Print(arr1);
        Print(arr2);
    }
    
    public static void Print<T>(T[] arr)
    {
        foreach(T t in arr)
            System.Console.WriteLine(t);
    }
}