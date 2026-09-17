using AdventOfCode.Common;

Console.WriteLine("Hello, World!");

public class NumberFinder
{
    public int GetLineValues(string text)
    {
        var digits = text.Where(char.IsDigit).ToArray();
        if (digits.Length == 0)
        {
            return 0;
        }
        return int.Parse($"{digits.First()}{digits.Last()}");
    }
}