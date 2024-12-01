using adventofcode_2024.Contracts;

namespace adventofcode_2024.Contest.day1;

public class Day1 : ISolver
{
    public string SolvePart1()
    {
        Console.WriteLine("Hello from Day 1 - Part 1");
        var lines = File.ReadLines("Contest/day1/input.txt");

        var leftList = lines
            .Select(l => l.Split("   ")[0])
            .Select(x => Convert.ToInt32(x))
            .ToList();

        var rightList = lines
            .Select(l => l.Split("   ")[1])
            .Select(x => Convert.ToInt32(x))
            .ToList();

        var distance = GetDistance(leftList, rightList);
        return $"Distance: {distance}";
    }

    private object GetDistance(List<int> leftList, List<int> rightList)
    {
        var distance = 0;
        leftList.Sort();
        rightList.Sort();
        for (int i = 0; i < leftList.Count; i++)
        {
            distance += Math.Abs(leftList[i] - rightList[i]);
        }

        return distance;
    }

    public string SolvePart2()
    {
        Console.WriteLine("Hello from Day 1 - Part 2");
        var lines = File.ReadLines("Contest/day1/input.txt");

        var leftList = lines
            .Select(l => l.Split("   ")[0])
            .Select(x => Convert.ToInt32(x))
            .ToList();

        var rightList = lines
            .Select(l => l.Split("   ")[1])
            .Select(x => Convert.ToInt32(x))
            .ToList();

        var similarity = GetSimilarity(leftList, rightList);
        return $"Similarity : {similarity}";
    }

    private object GetSimilarity(List<int> leftList, List<int> rightList)
    {
        var similarity = 0;
        for (int i = 0; i < leftList.Count; i++)
        {
            similarity += (leftList[i] * rightList.Count(x => x == leftList[i]));
        }

        return similarity;
    }
}