# Advent of Code 2024

This project is a solution framework for the Advent of Code 2024 challenges. It is written in C# and uses CommandLineParser for handling command-line arguments.

## Project Structure

- `Contest/`: Contains the main logic for solving the challenges.
  - `Solver.cs`: The main solver class that dynamically loads and executes the solution for a given day and part.
  - `day1/Day1.cs`: Example implementation for Day 1 challenge.
- `Contracts/`: Contains shared contracts and options.
  - `ProgramOptions.cs`: Defines the command-line options for specifying the day and part of the challenge.
- `Program.cs`: The entry point of the application that parses command-line arguments and invokes the solver.

## Usage

To run the solver, use the following command:

```sh
dotnet run -- -d <day> -p <part>
```

Replace `<day>` with the day number and `<part>` with the part number of the challenge you want to solve.

### Example

To solve Day 1, Part 1:

```sh
dotnet run -- -d 1 -p 1
```

## Adding New Solutions

1. Create a new class in the `Contest` folder for the specific day (e.g., `Day2.cs` for Day 2).
2. Implement the `ISolver` interface in the new class.
3. Implement the `SolvePart1` and `SolvePart2` methods with the logic for the respective parts of the challenge.

## Dependencies

- .NET 6.0 or later
- CommandLineParser

## License

This project is licensed under the MIT License. See the `LICENSE` file for details.