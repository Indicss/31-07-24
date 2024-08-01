using System;
using System.Collections.Generic;
using System.Linq;

public class StringValidator
{
    public static bool IsValidEmail(string email)
    {
        return email.Contains("@") && email.Contains(".");
    }

    public static bool IsPhoneNumber(string phoneNumber)
    {
        return phoneNumber.Length == 10 && phoneNumber.All(char.IsDigit);
    }
}

public class ListManipulator
{
    public static int FindMax(List<int> numbers)
    {
        return numbers.Max();
    }

    public static List<int> RemoveDuplicates(List<int> numbers)
    {
        return numbers.Distinct().ToList();
    }
}

public class Program
{
    public static void Main()
    {
        // Test StringValidator
        string email = "jalbaoleg00@gmail.com";
        string invalidEmail = "testexample.com";
        string phoneNumber = "069486039";
        string invalidPhoneNumber = "12345abcd";

        Console.WriteLine($"Is '{email}' a valid email? {StringValidator.IsValidEmail(email)}");
        Console.WriteLine($"Is '{invalidEmail}' a valid email? {StringValidator.IsValidEmail(invalidEmail)}");
        Console.WriteLine($"Is '{phoneNumber}' a valid phone number? {StringValidator.IsPhoneNumber(phoneNumber)}");
        Console.WriteLine($"Is '{invalidPhoneNumber}' a valid phone number? {StringValidator.IsPhoneNumber(invalidPhoneNumber)}");

        // Test ListManipulator
        List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 5, 6, 7, 8, 9, 9, 10 };
        Console.WriteLine($"Max value in list: {ListManipulator.FindMax(numbers)}");
        List<int> uniqueNumbers = ListManipulator.RemoveDuplicates(numbers);
        Console.WriteLine("List after removing duplicates:");
        uniqueNumbers.ForEach(n => Console.Write(n + " "));
    }
}
