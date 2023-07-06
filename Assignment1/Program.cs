public class Sample
{
    public static void Main()
    {
        string name, favorite;
        
        name = getString(nameof(name));
        favorite = getString(nameof(favorite));
        print(name, favorite);
    }
    public static string getString(string type)
    {
        System.Console.WriteLine("Please enter "+type+":");
        string? input = System.Console.ReadLine();
        return input;
    }
    public static void print(string name, string favorite)
    {
        Console.Clear();
        System.Console.WriteLine(name+" <"+favorite+">");
    }
}