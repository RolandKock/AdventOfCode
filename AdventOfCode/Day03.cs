using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventOfCode
{
    public class Day03 : BaseDay
    {
        private List<string> _input;

        public Day03()
        {
            _input = File.ReadAllText(InputFilePath).Split("\r\n").ToList();
        }

        private string solve1(List<string> input)
        {
            var parsedInput = new List<(string, string)>();

            foreach (var word in input)
            {
                parsedInput.Add((word.Substring(0, word.Length / 2), word.Substring(word.Length / 2)));
            }

            var score = 0;
            foreach (var word in parsedInput)
            {
                var commonChar = word.Item1.Intersect(word.Item2).First();
                score += char.IsUpper(commonChar) ? (byte)commonChar - 38 : (byte)commonChar - 96;
            }
            return score.ToString();
        }

        private string solve2(List<string> input)
        {
            return "";
        }


        public override ValueTask<string> Solve_1() => new(solve1(_input));       

        public override ValueTask<string> Solve_2() => new("");
    }
}
