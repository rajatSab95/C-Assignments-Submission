using System;
using System.Threading.Tasks;

class Program
{
    static async Task Main(string[] args)
    {
        try
        {
            await GetData();
        }
        catch (Exception ex)
        {
            Console.WriteLine("Exception :" + ex.Message);
        }
    }

    static async Task GetData()
    {
        await Task.Delay(2000); 

        
        throw new InvalidOperationException("Problem occured while fetching data.");
    }
}
