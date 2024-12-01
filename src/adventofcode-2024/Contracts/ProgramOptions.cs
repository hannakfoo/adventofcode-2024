using CommandLine;

namespace adventofcode_2024.Contracts;

public class ProgramOptions
{
    [Option('d', "day", Required = true, HelpText = "Day of the contest")]
    public int Day { get; set; }
    
    [Option('p', "part", Required = true, HelpText = "Part of the contest")]
    public int  Part { get; set; }
}