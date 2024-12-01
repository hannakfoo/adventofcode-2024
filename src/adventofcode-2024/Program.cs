using adventofcode_2024.Contracts;
using CommandLine;

namespace adventofcode_2024;

class Program
{
    static void Main(string[] args)
    {
        Parser
            .Default
            .ParseArguments<ProgramOptions>(args)
            .WithParsed(RunOptions);
    }

    private static void RunOptions(ProgramOptions options)
    {
        var solver = new Solver(options.Day, options.Part);
        var result = solver.Solve();
        Console.WriteLine(result);
    }
}