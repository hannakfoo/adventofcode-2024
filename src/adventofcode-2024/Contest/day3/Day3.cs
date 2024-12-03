using System.Text.RegularExpressions;
using adventofcode_2024.Contracts;

namespace adventofcode_2024.Contest.day3;

public class Day3 : ISolver 
{
    public string SolvePart1()
    {
        Console.WriteLine("Hello from Day 3 - Part 1");
        var input = File.ReadAllText("Contest/day3/input.txt");
        var regex = new Regex(@"mul\(\d+,\d+\)");
        var matches = regex.Matches(input);
        var result = 0;

        foreach (var match in matches)
        {
            var regex2 = new Regex(@"\d+");
            var values = regex2.Matches(match.ToString());
            result += Convert.ToInt32(values[0].ToString()) * Convert.ToInt32(values[1].ToString());
        }
        
        return result.ToString();
    }

    public string SolvePart2()
    {
        Console.WriteLine("Hello from Day 3 - Part 2");
        var input = File.ReadAllText("Contest/day3/input.txt");
        
        return "";
    }
}