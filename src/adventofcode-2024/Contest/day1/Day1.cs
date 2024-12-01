using adventofcode_2024.Contracts;

namespace adventofcode_2024.Contest.day1;

public class Day1 : ISolver
{
    public string SolvePart1()
    { 
        Console.WriteLine("Hello from Day 1 - Part 1");
        
        var leftlist = new List<int>();
        var rightlist = new List<int>();
        var lines = File.ReadLines("Contest/day1/input.txt");
        foreach (var line in lines)
        {
            var splitted = line.Split("   ");
            leftlist.Add(Convert.ToInt32(splitted[0]));
            rightlist.Add(Convert.ToInt32(splitted[1]));
        }
        
        var distance = 0;
        leftlist.Sort();
        rightlist.Sort();
        for (int i = 0; i < leftlist.Count; i++)
        {
            distance += Math.Abs(leftlist[i] - rightlist[i]);
        }

        return $"Distance: {distance}";
    }
    
    public string SolvePart2()
    {
        Console.WriteLine("Hellow from Day 1 - Part 2");
        
        var leftlist = new List<int>();
        var rightlist = new List<int>();
        var lines = File.ReadLines("Contest/day1/input.txt");
        foreach (var line in lines)
        {
            var splitted = line.Split("   ");
            leftlist.Add(Convert.ToInt32(splitted[0]));
            rightlist.Add(Convert.ToInt32(splitted[1]));
        }
        
        var similarity = 0;
        for (int i = 0; i < leftlist.Count; i++)
        {
            similarity += (leftlist[i] * rightlist.Count(x => x == leftlist[i]));
        }

        return $"Similarity : {similarity}";
    }
}

