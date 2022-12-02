using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventOfCode
{
    public class Day02 : BaseDay
    {
        // Rock, Paper, Scissors

        private readonly List<(char, char)> _parsedInput = new();
        private int _totalPoint;

        public Day02()
        {
            var _input = File.ReadAllText(InputFilePath).Split("\r\n");

            foreach (var move in _input)
            {
                _parsedInput.Add((move[0], move[2]));
            }
        }
        //Elves
        // A = Rock
        // B = Paper
        // C = Scissors

        //Human
        // X = Rock
        // Y = Paper
        // Z = Scissors

        //Format (A, X) etc

        //Round score
        //Rock = 1
        //Paper = 2
        //Scissors = 3

        //Loss = 0
        //Draw = 3
        //Win = 6

        private string Solve1_naive(List<(char, char)> _parsedInput)
        {
            _totalPoint = 0;
            foreach (var move in _parsedInput)
            {
                switch (move)
                {
                    // Rock vs X
                    case ('A', 'X'):
                        _totalPoint += 4;
                        break;
                    case ('A', 'Y'):
                        _totalPoint += 8;
                        break;
                    case ('A', 'Z'):
                        _totalPoint += 3;
                        break;
                    // Paper vs X
                    case ('B', 'X'):
                        _totalPoint += 1;
                        break;
                    case ('B', 'Y'):
                        _totalPoint += 5;
                        break;
                    case ('B', 'Z'):
                        _totalPoint += 9;
                        break;
                    // Scissors vs X
                    case ('C', 'X'):
                        _totalPoint += 7;
                        break;
                    case ('C', 'Y'):
                        _totalPoint += 2;
                        break;
                    case ('C', 'Z'):
                        _totalPoint += 6;
                        break;
                    default: 
                        throw new ArgumentOutOfRangeException(nameof(move));

                }
            }
            return _totalPoint.ToString();
        }

        public override ValueTask<string> Solve_1() => new(Solve1_naive(_parsedInput));

        // Part 2
        // Match the last part
        // X = Lose
        // Y = Draw
        // Z = Win

        private string Solve2_naive(List<(char, char)> _parsedInput)
        {
            _totalPoint = 0;
            foreach (var move in _parsedInput)
            {
                switch (move)
                {
                    // Rock vs X
                    case ('A', 'X'):
                        _totalPoint += 3;
                        break;
                    case ('A', 'Y'):
                        _totalPoint += 4;
                        break;
                    case ('A', 'Z'):
                        _totalPoint += 8;
                        break;
                    // Paper vs X
                    case ('B', 'X'):
                        _totalPoint += 1;
                        break;
                    case ('B', 'Y'):
                        _totalPoint += 5;
                        break;
                    case ('B', 'Z'):
                        _totalPoint += 9;
                        break;
                    // Scissors vs X
                    case ('C', 'X'):
                        _totalPoint += 2;
                        break;
                    case ('C', 'Y'):
                        _totalPoint += 6;
                        break;
                    case ('C', 'Z'):
                        _totalPoint += 7;
                        break;
                    default:
                        throw new ArgumentOutOfRangeException(nameof(move));

                }
            }
            return _totalPoint.ToString();
        }

        public override ValueTask<string> Solve_2() => new(Solve2_naive(_parsedInput));
    }
}
