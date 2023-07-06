using System;
using System.Threading.Tasks;

class Program
{
    static bool isCanceled = false;

    static async Task Main(string[] args)
    {
        Task operationTask = GetData();

        Console.WriteLine("Press 'Enter' to cancel the operation.");
        Console.ReadLine();

        isCanceled = true;

        try
        {
            await operationTask;
            Console.WriteLine("Operation completed successfully.");
        }
        catch (Exception ex)
        {
            Console.WriteLine("Exception caught: " + ex.Message);
        }
    }

    static async Task GetData()
    {
        await Task.Delay(7000); 

        if (isCanceled)
        {
            throw new OperationCanceledException();
        }

        
        Console.WriteLine("Async operation completed.");
    }
}
