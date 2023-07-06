using System;

namespace MatrixOperations{

    class Matrix
    {
        public static void Main()
        {
            try
            {
                Menu();
            }
            catch(Exception e)
            {
                System.Console.WriteLine("Something went wrong. Please try again."+e);
            }
        }
        public static void Menu()
        {
            System.Console.WriteLine("Please make your choice:\n"
            +"1. Matrix Addition\n"
            +"2. Matrix Subtraction\n"
            +"3. Matrix Multiplication"
            +"4. Transpose of Matrix");
            
            int choice;
            int.TryParse(System.Console.ReadLine(), out choice);
            
            switch(choice)
            {
                case 1:
                {
                    Addition();
                    break;
                }
                case 2:
                {
                    Subtraction();
                    break;
                }
                case 3:
                {
                    Multiplication();
                    break;
                }
                case 4:
                {
                    Transpose();
                    break;
                }
                default:
                {
                    System.Console.WriteLine("Invalid Choice! Please try Again...");
                    Menu();
                    break;
                }
            }

        



        
        }

        public static void Addition(){
            System.Console.WriteLine("Please enter 1st Matrix elements:");
            int [,] Matrix1 = GetMatrix();
            System.Console.WriteLine("Please enter 2nd Matrix elements:");
            int [,] Matrix2 = GetMatrix();
            Add(Matrix1, Matrix2);
        }

        public static int[,] Add(int[,] arr1, int[,] arr2)
        {
            int[,] result= new int[3,3];
            System.Console.WriteLine("Adding Matrix2 from matrix1...");
            for(int i=0; i<3; i++)
            {
                for(int j=0; j<3; j++)
                {
                    result[i, j] = arr1[i, j]+ arr2[i, j];
                }
            }
            PrintResult(result);
            return result;
        }
        public static void Subtraction(){
            System.Console.WriteLine("Please enter 1st Matrix elements:");
            int [,] Matrix1 = GetMatrix();
            System.Console.WriteLine("Please enter 2nd Matrix elements:");
            int [,] Matrix2 = GetMatrix();
            Subtract(Matrix1, Matrix2);
        }

        public static int[,] Subtract(int[,] arr1, int[,] arr2)
        {
            int[,] result= new int[3,3];
            System.Console.WriteLine("Subtracting Matrix2 from matrix1...");
            for(int i=0; i<3; i++)
            {
                for(int j=0; j<3; j++)
                {
                    result[i, j] = arr1[i, j]- arr2[i, j];
                }
            }
            PrintResult(result);
            return result;
        }

        public static void Multiplication()
        {
            System.Console.WriteLine("Please enter 1st Matrix elements:");
            int [,] Matrix1 = GetMatrix();
            System.Console.WriteLine("Please enter 2nd Matrix elements:");
            int [,] Matrix2 = GetMatrix();
            Multiply(Matrix1, Matrix2);
        }

        public static int[,] Multiply(int[,] arr1, int[,] arr2)
        {
            int row1 = arr1.GetLength(0);
            int col1 = arr1.GetLength(1);
            int row2 = arr2.GetLength(0);
            int col2 = arr2.GetLength(1);
            if(col1!=row2)
                throw new Exception("Invalid Matrix size to perform action. Please try again.");
            
            int[,] result= new int[row1, row2];

            for(int i=0; i<row1; i++)
            {
                for(int j=0; j<col2; j++)
                {
                    int sum=0;
                    for(int k=0; k<col1; k++)
                    {
                        sum+=arr1[i, k] * arr2[k, j];
                    }
                    result[i,j] = sum;
                }
            }

            return result;
        }

        public static void Transpose()
        {
            int[,] matrix = GetMatrix();
            int row = matrix.GetLength(0);
            int col = matrix.GetLength(1);

            int[,] result = new int[row, col];
            for(int i=0; i<row; i++)
            {
                for(int j=0; j<col; j++)
                {
                    result[row-i-1, col-j-1] = matrix[i,j];
                }
            }
            PrintResult(result);
        }

        public static int[,] GetMatrix()
        {
            
            int rows, cols;
            System.Console.WriteLine("Please enter number of rows:");
            int.TryParse(System.Console.ReadLine(), out rows);
            System.Console.WriteLine("Please enter number of Columns:");
            int.TryParse(System.Console.ReadLine(), out cols);
            int[,] matrix = new int[rows, cols];
            for(int i=0; i<rows; i++)
            {
                for(int j=0; j<cols; j++)
                {
                    System.Console.WriteLine("Enter ["+(i+1)+", "+(j+1)+"] th element");
                    int.TryParse(System.Console.ReadLine(), out matrix[i,j]);
                }
            }
            return matrix;
        }
        public static void PrintResult(int[,] result)
        {
            int row = result.GetLength(0);
            int col = result.GetLength(1);

            System.Console.WriteLine("Result :");
            for(int i=0; i<row; i++)
            {
                for(int j=0; j<col; j++)
                {
                    System.Console.Write(result[i,j]+" ");
                }
                System.Console.WriteLine();
            }
        }
    }
}