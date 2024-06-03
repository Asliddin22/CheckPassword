using System;
class Program
{
    static void Main()
    {
        Console.WriteLine("Введите строку для проверки:");
        string input = Console.ReadLine();

        if (string.IsNullOrEmpty(input))
        {
            Console.WriteLine("Строка не должна быть пустой.");
            return;
        }

        bool hasLowercase = false;
        bool hasDigit = false;
        bool hasUppercase = false;
        bool hasSpecialChar = false;

        foreach (char c in input)
        {
            if (char.IsLower(c))
                hasLowercase = true;
            else if (char.IsDigit(c))
                hasDigit = true;
            else if (char.IsUpper(c))
                hasUppercase = true;
            else if (!char.IsLetterOrDigit(c))
                hasSpecialChar = true;

            
            if (hasLowercase && hasDigit && hasUppercase && hasSpecialChar)
                break;
        }

        if (hasLowercase && hasDigit && hasUppercase && hasSpecialChar)
        {
            Console.WriteLine("Строка содержит хотя бы одну букву в нижнем регистре, цифру, букву в верхнем регистре и специальный символ.");
        }
        else
        {
            Console.WriteLine("Строка не соответствует всем требованиям.");
        }
    }
}
