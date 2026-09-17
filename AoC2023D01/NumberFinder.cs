using AdventOfCode.Common;

Console.WriteLine("Hello, World!");

public class NumberFinder
{
    public int GetLineValue(string text)
    {
        var digits = text.Where(char.IsDigit).ToArray();
        if (digits.Length == 0)
        {
            return 0;
        }
        return int.Parse($"{digits.First()}{digits.Last()}");
    }
    public int SumAllLineValues(string text)
    {
        var lines = Input.Lines(text);
        return lines.Sum(GetLineValue);
    }
}