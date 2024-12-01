using System.Reflection;
using adventofcode_2024.Contracts;

namespace adventofcode_2024;

public class Solver
{
    private readonly int _day;
    private readonly int _part;

    public Solver(int day, int part)
    {
        _day = day;
        _part = part;
    }

    public string Solve()
    {
        var solver = Assembly
            .GetExecutingAssembly()
            .GetTypes()
            .Where(t => typeof(ISolver).IsAssignableFrom(t))
            .SingleOrDefault(t => t.Name.Equals($"Day{_day}"));

        if (solver == null)
        {
            return($" Error: No solver found for Day {_day} Part {_part}");
        }
        
        var instance = (ISolver)Activator.CreateInstance(solver)!;
        return _part switch
        {
            1 => instance.SolvePart1(),
            2 => instance.SolvePart2(),
            _ => throw new ArgumentException("Part must be 1 or 2, there are only 2 parts to solve!")
        };
    }
}