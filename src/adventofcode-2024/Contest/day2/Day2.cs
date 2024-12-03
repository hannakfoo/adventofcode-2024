using adventofcode_2024.Contracts;
using adventofcode_2024.Extensions;

namespace adventofcode_2024.Contest.day2;

public class Day2 : ISolver
{
    public string SolvePart1()
    {
        Console.WriteLine("Hello from Day 2 - Part 1");
        var levels = File.ReadLines("Contest/day2/input.txt");
        
        var result = 0;
        foreach (var level in levels)
        {
            var numbers = level.Split(" ")
                .Select(x => Convert.ToInt32(x)).ToArray();
            
            if(numbers.IsIncreasing() || numbers.IsDecreasing())
            {
                if (numbers.IsSafe())
                {
                    result++;
                }
            }
        }

        return $"Total increasing or decreasing levels: {result}";
    }
    
    public string SolvePart2()
    {
        Console.WriteLine("Hello from Day 2 - Part 2");
        var levels = File.ReadLines("Contest/day2/input.txt");
        
        var result = 0;
        foreach (var level in levels)
        {
            var numbers = level.Split(" ")
                .Select(x => Convert.ToInt32(x)).ToArray();
            
            if(numbers.IsIncreasing() || numbers.IsDecreasing())
            {
                if (numbers.IsSafe() || numbers.IsSafeAfterRemovingOneLevel())
                {
                    result++;
                }
            }
        }

        return $"Total increasing or decreasing levels: {result}";
    }
}