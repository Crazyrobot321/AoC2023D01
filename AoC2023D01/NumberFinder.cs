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

    private static Dictionary<string, char> wordToDigits = new Dictionary<string, char>
    {
        { "zero", '0' },
        { "one", '1' },
        { "two", '2' },
        { "three", '3' },
        { "four", '4' },
        { "five", '5' },
        { "six", '6' },
        { "seven", '7' },
        { "eight", '8' },
        { "nine", '9' }
    };

    public int GetLineValueWithWords(string line)
    {
        var digits = new List<char>();
        for(int i = 0; i < line.Length; i++)
        {
            if (char.IsDigit(line[i]))
            {
                digits.Add(line[i]);
            }
            else
            {
                foreach (var (word, digit) in wordToDigits)
                {
                    if(line.AsSpan(i).StartsWith(word))
                    {
                        digits.Add(digit);
                        break;
                    }
                }
            }
        }
        if (digits.Count == 0)
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
    public int SumAllLineValuesWithWords(string text)
    {
        var lines = Input.Lines(text);
        return lines.Sum(GetLineValueWithWords);
    }
}