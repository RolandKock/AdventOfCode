namespace AdventOfCode;

public class Day01 : BaseDay
{
    private readonly List<int> _parsedInput = new();

    public Day01()
    {
        var input = File.ReadAllText(InputFilePath).Split("\r\n");

        var totalCalories = 0;

        foreach (var calories in input)
        {
            if (calories != "")
            {
                totalCalories += int.Parse(calories);
            }
            else
            {
                _parsedInput.Add(totalCalories);
                totalCalories = 0;
            }
        }
    }

    public override ValueTask<string> Solve_1() => new(_parsedInput.Max().ToString());

    public override ValueTask<string> Solve_2() => new(_parsedInput.OrderByDescending(x => x).Take(3).Sum().ToString());
}
