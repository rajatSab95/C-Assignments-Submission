class Delegate
{
    public delegate void MyDelegate();

    public static void Main()
    {
        MyDelegate delega = new MyDelegate(PrintToConsole);
        delega += new MyDelegate(PrintToFile);
        delega.Invoke();
    }
    public static void PrintToConsole()
    {
        System.Console.WriteLine("Printing on Console");
    }
    public static void PrintToFile()
    {
        System.Console.WriteLine("Printing on File");
    }
}