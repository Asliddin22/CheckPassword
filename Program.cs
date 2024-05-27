using System;
using System.Linq;

class Program
{
    static void Main()
    {
        Console.WriteLine("Введите строку для проверки:");
        string input = Console.ReadLine();
        
        if (ContainsLowercase(input) && ContainsDigit(input) && ContainsUppercase(input) && ContainsSpecialCharacter(input))
        {
            Console.WriteLine("Строка содержит хотя бы одну букву в нижнем регистре, цифру, букву в верхнем регистре и специальный символ.");
        }
        else
        {
            Console.WriteLine("Строка не соответствует всем требованиям.");
        }
    }

    static bool ContainsLowercase(string str)
    {
        return str.Any(char.IsLower);
    }

    static bool ContainsDigit(string str)
    {
        return str.Any(char.IsDigit);
    }

    static bool ContainsUppercase(string str)
    {
        return str.Any(char.IsUpper);
    }

    static bool ContainsSpecialCharacter(string str)
    {
        return str.Any(c => !char.IsLetterOrDigit(c));
    }
}