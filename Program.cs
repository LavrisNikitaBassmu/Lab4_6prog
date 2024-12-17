using System;
using System.Text.RegularExpressions;

class Program
{
    static void Main()
    {
        Console.WriteLine("Введите строку (например, «15 + 36 = 51»):");
        string input = Console.ReadLine();

        // Регулярное выражение для разбора строки
        string pattern = @"\s*(-?\d+)\s*\+\s*(-?\d+)\s*=\s*(-?\d+)\s*";

        // Создаем объект Regex
        Regex regex = new Regex(pattern);

        // Находим совпадение
        Match match = regex.Match(input);

        if (match.Success)
        {
            // Извлекаем операнды и сумму
            int operand1 = int.Parse(match.Groups[1].Value);
            int operand2 = int.Parse(match.Groups[2].Value);
            int sum = int.Parse(match.Groups[3].Value);

            // Выводим результаты
            Console.WriteLine($"Первый операнд: {operand1}");
            Console.WriteLine($"Второй операнд: {operand2}");
            Console.WriteLine($"Сумма: {sum}");
        }
        else
        {
            Console.WriteLine("Некорректный формат ввода.");
        }
    }
}