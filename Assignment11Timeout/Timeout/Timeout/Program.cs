using System;
using System.Threading;
using System.Threading.Tasks;

namespace Sample
{
    class Timout
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Press any key to start the operation.");
            Console.ReadKey();

            ShowMessage("Message Displayed...");

            StartLongOperation();

            Console.WriteLine("Press any key to abort the long operation.");
            Console.ReadKey();

            AbortLongOperation();

            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();
        }

        static async void ShowMessage(string message)
        {
            CancellationTokenSource cancellationTokenSource = new CancellationTokenSource();
            CancellationToken cancellationToken = cancellationTokenSource.Token;

            Console.WriteLine(message);

            try
            {
                await Task.Delay(15000, cancellationToken);
            }
            catch (TaskCanceledException)
            {
                System.Console.WriteLine("Mannually Closed the Message box.");
                return;
            }

            Console.WriteLine("Dialog closed after timeout.");
        }

        static async void StartLongOperation()
        {
            CancellationTokenSource cancellationTokenSource = new CancellationTokenSource();
            CancellationToken cancellationToken = cancellationTokenSource.Token;
            bool longOperationFinished = false;

            await Task.Delay(5000, cancellationToken);

            longOperationFinished = true;

            await Task.Delay(1000);

            if (!longOperationFinished)
            {
                Console.WriteLine("In Progress...");
            }
        }

        static void AbortLongOperation()
        {
            System.Console.WriteLine("Operation Completed Execution. ");
        }
    }
}
