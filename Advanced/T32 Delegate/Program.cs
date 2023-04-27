using System;
using System.Globalization;

delegate string StringTransformationDelegate(string input);

class Program
{
    static string ConvertToUppercase(string input)
    {
        return input.ToUpper();
    }

    static string ConvertToLowercase(string input)
    {
        return input.ToLower();
    }

    static string ConvertToTitleCase(string input)
    {
        return CultureInfo.CurrentCulture.TextInfo.ToTitleCase(input.ToLower());
    }

    static string ReverseString(string input)
    {
        char[] charArray = input.ToCharArray();
        Array.Reverse(charArray);
        return new string(charArray);
    }

    static void Main(string[] args)
    {
        Console.WriteLine("Enter the string to process:");
        string input = Console.ReadLine();

        StringTransformationDelegate transformationDelegate = null;

        while (true)
        {
            Console.WriteLine("Choose the treatment you want, you can give several treatments at once as one string, e.g. '123'");
            Console.WriteLine("1: Convert to uppercase");
            Console.WriteLine("2: Convert to lowercase");
            Console.WriteLine("3: Convert to title case");
            Console.WriteLine("4: Reverse the string");
            Console.WriteLine("0: Terminate");

            string selection = Console.ReadLine();

            if (selection == "0")
            {
                break;
            }


            transformationDelegate += selection.Contains("1") ? ConvertToUppercase : null;
            transformationDelegate += selection.Contains("2") ? ConvertToLowercase : null;
            transformationDelegate += selection.Contains("3") ? ConvertToTitleCase : null;
            transformationDelegate += selection.Contains("4") ? ReverseString : null;

            if (transformationDelegate != null)
            {
                string transformedString = transformationDelegate(input);
                Console.WriteLine($"Input: {input}, Transformed: {transformedString}");
            }
            else
            {
                Console.WriteLine("No transformation selected.");
            }

            transformationDelegate = null;
        }
    }
}
