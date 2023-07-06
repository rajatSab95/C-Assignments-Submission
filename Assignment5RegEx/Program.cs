
using System;
using System.Text.RegularExpressions;

class Program
{
    static void Main()

    {

        Console.Write("Enter your password: ");

        string password = Console.ReadLine();

        if (ValidatePassword(password))

            Console.WriteLine("Password is valid!");

        else

            Console.WriteLine("Password is invalid!");

    }

    static bool ValidatePassword(string password)

    {

        if (password.Length < 8)                                                         // Check length (at least 8 characters)

            return false;

        if (!Regex.IsMatch(password, "[A-Z]"))                                         // Check for at least one uppercase letter

            return false;

        if (!Regex.IsMatch(password, "[a-z]"))                                         // Check for at least one lowercase letter

            return false;

        if (!Regex.IsMatch(password, @"\d"))                                          // Check for at least one digit

            return false;

        if (!Regex.IsMatch(password, @"[!@#$%^&*()-=_+{}\[\]|\\;:'"",.<>/?]"))      // Check for at least one special symbol

            return false;

        return true;

    }

}


