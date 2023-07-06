using System;

namespace EventExample
{
    public class MathOperations
    {
        // Event declaration 
        public event EventHandler<int> AdditionPerformed;
        public event EventHandler<int> SubtractionPerformed;

        // Method to perform addition and Subtraction
        public void PerformAddition(int num1, int num2)
        {
            int result = num1 + num2;
            OnAdditionPerformed(result);
        }

        public void PerformSubtraction(int num1, int num2)
        {
            int result = num1 - num2;
            OnSubtractionPerformed(result);
        }

        // Event invocation for addition and Subtraction
        protected virtual void OnAdditionPerformed(int result)
        {
            AdditionPerformed?.Invoke(this, result);
        }
        protected virtual void OnSubtractionPerformed(int result)
        {
            SubtractionPerformed?.Invoke(this, result);
        }
    }

    public class Program
    {
        static void Main()
        {
            MathOperations mathOperations = new MathOperations();

            // Subscribe to the respective event
            mathOperations.AdditionPerformed += AdditionEventHandler;
            mathOperations.SubtractionPerformed += SubtractionEventHandler;

            
            int num1, num2;
            System.Console.WriteLine("Enter Num1 : ");
            int.TryParse(Console.ReadLine(), out num1);
            System.Console.WriteLine("Enter Num2 : ");
            int.TryParse(Console.ReadLine(), out num2);
            // Perform addition and Subtraction
            mathOperations.PerformAddition(num1, num2);
            mathOperations.PerformSubtraction(num1, num2);
        }

        // Event handler for addition and Subtraction
        static void AdditionEventHandler(object sender, int result)
        {
            Console.WriteLine("Addition Performed: " + result);
        }
        static void SubtractionEventHandler(object sender, int result)
        {
            Console.WriteLine("Subtraction Performed: " + result);
        }
    }
}
