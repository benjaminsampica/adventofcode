﻿namespace _2023;

public static class DayTwoInput
{
    public static readonly string[] Input =
        [
            "Game 1: 7 green, 4 blue, 3 red; 4 blue, 10 red, 1 green; 1 blue, 9 red",
            "Game 2: 2 red, 4 blue, 3 green; 5 green, 3 red, 1 blue; 3 green, 5 blue, 3 red",
            "Game 3: 12 red, 1 blue; 6 red, 2 green, 3 blue; 2 blue, 5 red, 3 green",
            "Game 4: 3 green, 1 red, 3 blue; 1 red; 2 green, 1 red, 1 blue; 3 green, 1 blue; 2 blue; 2 green, 4 blue",
            "Game 5: 3 blue, 3 red, 8 green; 5 blue, 1 red; 1 green, 19 blue, 3 red; 1 red, 5 green, 3 blue; 4 green, 20 blue, 4 red; 20 blue, 4 green",
            "Game 6: 7 green, 6 blue, 1 red; 3 blue, 5 green, 3 red; 9 blue, 3 red, 6 green; 8 blue, 11 green, 3 red; 2 blue, 1 red; 7 green, 4 blue, 1 red",
            "Game 7: 5 green, 1 blue; 2 green, 2 blue; 1 blue, 1 red; 5 blue, 2 green; 3 green",
            "Game 8: 5 blue, 5 red, 10 green; 6 green, 1 blue, 1 red; 5 red, 2 blue, 16 green; 2 blue, 14 green, 9 red; 9 red, 3 green, 7 blue; 8 red, 4 blue, 10 green",
            "Game 9: 1 red, 1 blue, 7 green; 4 red, 6 green, 2 blue; 6 green, 14 blue, 3 red",
            "Game 10: 1 red, 16 green, 3 blue; 1 red, 3 blue; 6 green; 4 green, 2 blue, 1 red",
            "Game 11: 5 red, 2 blue; 14 blue, 8 red, 10 green; 8 green, 1 red, 15 blue; 2 green, 5 red, 11 blue; 8 red, 11 blue, 4 green",
            "Game 12: 5 green, 8 blue, 4 red; 15 green, 8 blue, 8 red; 13 red, 1 blue; 6 blue, 7 green, 14 red; 9 red",
            "Game 13: 7 blue, 5 red; 3 green, 10 blue; 5 blue, 2 green, 5 red; 3 blue, 1 green, 5 red; 6 blue, 4 red, 6 green; 5 red, 2 green, 6 blue",
            "Game 14: 5 red, 1 blue, 5 green; 6 blue, 13 green, 4 red; 7 blue, 4 red, 1 green; 6 blue, 5 red; 2 red, 7 blue, 2 green",
            "Game 15: 8 red, 16 green; 10 green, 1 blue; 16 green, 7 blue, 3 red; 13 red, 7 blue, 8 green; 4 red, 2 green, 8 blue",
            "Game 16: 1 red, 1 blue, 5 green; 5 green, 2 red; 2 green, 1 red; 3 red, 4 green",
            "Game 17: 3 green, 7 blue, 5 red; 2 red, 1 blue; 8 blue, 1 red",
            "Game 18: 9 green, 6 blue, 3 red; 3 red, 15 green, 5 blue; 7 green, 3 red, 3 blue",
            "Game 19: 4 green, 3 red, 7 blue; 4 blue, 6 red, 4 green; 6 red, 5 green, 1 blue; 6 blue, 4 green, 3 red; 5 green, 5 red, 2 blue",
            "Game 20: 3 green, 5 blue, 1 red; 1 red, 1 blue; 1 red, 6 blue; 1 green, 4 blue",
            "Game 21: 2 green, 1 blue, 3 red; 16 green, 1 blue, 4 red; 11 green, 2 red, 1 blue; 6 green, 1 blue; 10 green, 1 red, 1 blue",
            "Game 22: 1 blue, 2 green, 4 red; 3 red, 4 green; 1 blue, 3 red, 10 green; 7 green, 1 blue",
            "Game 23: 2 red, 14 blue; 2 red, 14 blue; 1 red, 14 blue, 1 green; 1 red, 6 blue; 13 blue, 1 green",
            "Game 24: 3 green, 7 blue, 3 red; 4 green, 2 blue; 12 blue, 8 red, 4 green; 10 blue, 9 red, 1 green; 13 blue, 4 red; 12 blue, 9 red, 2 green",
            "Game 25: 9 green, 11 red; 14 green, 3 red, 1 blue; 8 red, 7 green; 10 red, 8 green, 1 blue; 6 red, 11 green, 1 blue",
            "Game 26: 10 blue, 6 red, 11 green; 9 red, 2 green, 10 blue; 5 red; 9 red, 8 blue, 7 green; 13 green, 10 red, 1 blue",
            "Game 27: 3 blue, 1 green; 10 green, 1 blue; 8 red, 6 green, 6 blue",
            "Game 28: 10 blue, 2 red, 13 green; 2 blue, 2 red, 6 green; 10 blue; 4 red, 4 blue, 11 green; 3 green, 2 red, 6 blue; 14 green, 2 red, 2 blue",
            "Game 29: 8 blue, 5 red, 6 green; 1 green, 4 blue, 15 red; 8 blue, 14 red, 3 green; 9 blue, 4 red, 5 green; 3 red, 3 green, 4 blue",
            "Game 30: 19 green, 14 blue, 2 red; 2 red, 8 green, 7 blue; 4 blue, 1 red, 13 green; 10 blue, 3 green; 8 blue, 2 red",
            "Game 31: 12 green, 5 blue, 3 red; 15 blue, 11 green, 6 red; 6 green, 6 red; 4 green, 6 blue, 10 red",
            "Game 32: 7 red, 2 green, 3 blue; 9 red, 1 green; 2 green, 5 red, 1 blue; 12 red; 14 red, 4 blue",
            "Game 33: 9 red, 4 green, 6 blue; 4 red, 10 green; 16 red, 4 green, 4 blue; 15 blue, 12 red",
            "Game 34: 5 green, 1 blue; 18 red, 1 green, 1 blue; 1 blue, 9 green, 3 red; 6 green, 11 red",
            "Game 35: 2 blue, 19 green, 6 red; 16 green, 1 red, 1 blue; 1 green, 2 blue, 5 red; 8 green, 3 blue, 13 red; 11 red, 10 green, 4 blue",
            "Game 36: 17 green, 6 blue; 10 blue, 2 red, 8 green; 16 green, 4 blue, 1 red",
            "Game 37: 9 green, 7 red, 8 blue; 1 blue, 10 red; 10 red, 4 blue, 11 green; 8 green, 11 red, 5 blue",
            "Game 38: 8 green, 11 blue; 13 green, 2 blue; 7 blue, 2 red, 8 green",
            "Game 39: 14 red, 2 green; 2 red, 3 green, 1 blue; 4 red, 5 green, 4 blue; 2 blue, 3 red, 1 green; 17 red, 2 blue; 5 green, 3 red",
            "Game 40: 10 blue; 2 red, 9 blue; 5 red, 1 green, 2 blue; 8 blue, 2 red; 6 blue, 2 red; 4 red, 2 blue, 1 green",
            "Game 41: 2 blue, 3 red, 2 green; 4 green, 2 red, 11 blue; 11 blue, 3 red, 1 green; 1 red, 6 green, 1 blue; 5 red, 7 green",
            "Game 42: 1 blue, 14 green, 1 red; 2 blue, 2 green; 5 green, 2 blue, 8 red",
            "Game 43: 15 red, 5 blue, 5 green; 15 green, 15 red, 1 blue; 4 blue, 13 green, 13 red; 3 red, 16 green; 2 red, 3 green, 2 blue",
            "Game 44: 8 green, 8 blue; 9 blue, 9 green; 9 green, 3 blue; 8 green, 3 blue; 8 blue, 2 green; 9 blue, 1 red, 8 green",
            "Game 45: 4 red, 4 blue, 4 green; 5 red, 2 green, 9 blue; 8 blue, 5 red, 3 green; 4 red, 3 blue; 5 red, 5 green, 1 blue",
            "Game 46: 1 blue, 9 green, 2 red; 2 blue, 9 green, 1 red; 8 green, 3 red",
            "Game 47: 2 green, 4 blue, 10 red; 4 green, 5 blue, 1 red; 10 green, 13 red, 6 blue; 4 green, 4 blue, 12 red; 15 red, 1 blue, 4 green",
            "Game 48: 1 red, 7 green; 2 blue, 4 green, 5 red; 5 red, 3 green, 1 blue; 8 green",
            "Game 49: 3 blue, 4 green, 3 red; 6 red, 5 green, 5 blue; 1 blue, 4 green, 3 red; 6 red, 1 blue, 5 green; 4 red, 3 green, 5 blue; 2 green, 3 blue, 1 red",
            "Game 50: 1 green, 5 red, 6 blue; 3 red, 2 green; 1 red, 1 green, 6 blue; 1 green, 7 red, 3 blue",
            "Game 51: 7 green, 8 blue; 6 blue, 6 red, 4 green; 6 green, 1 blue; 8 blue, 5 red, 4 green",
            "Game 52: 7 red, 3 blue, 6 green; 7 green, 5 red, 4 blue; 6 red, 4 blue",
            "Game 53: 12 blue, 1 red, 5 green; 4 green, 2 blue, 5 red; 5 red, 4 green; 1 green, 3 blue, 5 red; 5 blue, 2 red, 5 green",
            "Game 54: 15 green, 12 red; 11 red, 3 green, 2 blue; 3 blue, 6 green; 3 red, 1 blue, 5 green; 17 red, 7 green",
            "Game 55: 7 green, 10 red, 7 blue; 8 red, 4 blue, 11 green; 9 green, 11 red",
            "Game 56: 7 green, 3 blue, 5 red; 6 green, 1 red, 4 blue; 4 green, 2 red; 5 blue, 6 red, 8 green",
            "Game 57: 1 green, 3 red, 3 blue; 5 blue, 2 red, 2 green; 1 green, 5 blue",
            "Game 58: 4 red, 2 green; 13 green, 4 red, 1 blue; 12 green, 4 blue",
            "Game 59: 4 red, 4 green; 5 blue, 1 green, 20 red; 11 red, 3 green, 15 blue; 5 blue, 7 red, 3 green; 18 blue, 4 green, 19 red",
            "Game 60: 5 blue, 8 red, 4 green; 4 blue, 12 green, 19 red; 3 blue, 1 green, 17 red; 1 green, 3 blue; 2 green, 6 blue, 3 red",
            "Game 61: 3 red, 7 blue, 12 green; 7 red, 1 green, 6 blue; 6 red, 2 green, 18 blue; 14 blue, 5 red, 1 green",
            "Game 62: 1 red, 2 blue; 1 green, 3 red; 1 green, 9 blue, 4 red",
            "Game 63: 6 green, 4 blue, 17 red; 2 green, 2 blue, 12 red; 10 green, 9 blue, 13 red; 15 red, 8 green, 5 blue",
            "Game 64: 4 green, 7 blue, 10 red; 3 green, 4 blue, 12 red; 6 green, 6 red, 8 blue; 4 green, 9 red, 1 blue; 2 blue, 15 red, 15 green",
            "Game 65: 5 green, 4 blue, 7 red; 6 green, 7 blue, 8 red; 1 green, 7 red; 1 blue, 10 red, 8 green",
            "Game 66: 5 green, 5 blue, 2 red; 3 red; 1 red, 1 blue, 16 green; 2 blue, 1 green; 8 green, 1 blue, 3 red; 14 green, 4 red",
            "Game 67: 12 blue, 7 green; 7 blue, 7 green, 1 red; 12 blue, 1 green, 6 red",
            "Game 68: 2 blue, 8 red, 1 green; 9 blue, 3 green, 12 red; 14 blue, 15 red, 6 green",
            "Game 69: 7 red, 1 blue; 11 green, 2 blue, 13 red; 3 blue, 13 green, 3 red; 1 blue, 10 red, 8 green; 15 red, 2 blue, 19 green",
            "Game 70: 10 green, 10 red, 12 blue; 7 red, 15 blue, 2 green; 8 blue, 9 green",
            "Game 71: 1 blue, 2 green, 13 red; 7 red; 1 green, 5 red",
            "Game 72: 2 red, 1 blue, 11 green; 1 red, 2 blue, 18 green; 5 red, 3 blue, 3 green",
            "Game 73: 13 red, 3 blue, 4 green; 3 green, 17 red, 1 blue; 6 blue, 4 green, 4 red; 13 red, 7 blue",
            "Game 74: 1 blue, 3 red; 13 blue, 5 red, 2 green; 1 red, 8 green, 11 blue; 4 blue, 1 green, 5 red; 11 blue, 8 red, 6 green; 8 red, 3 green, 4 blue",
            "Game 75: 7 blue, 4 green, 1 red; 3 green, 4 blue; 5 green, 2 red, 3 blue; 6 blue, 3 red, 5 green",
            "Game 76: 9 green, 1 blue, 4 red; 6 red, 9 green, 3 blue; 2 red, 6 green, 2 blue; 5 green; 6 green, 2 red, 3 blue; 6 blue, 5 red, 5 green",
            "Game 77: 2 green, 2 red; 1 blue, 6 red, 2 green; 4 green, 3 red, 2 blue; 2 blue, 1 green, 1 red",
            "Game 78: 2 green, 10 red, 2 blue; 6 green, 2 red, 2 blue; 2 blue, 9 red, 6 green; 11 red, 6 green; 3 red, 8 green; 1 blue, 6 green, 1 red",
            "Game 79: 3 blue, 8 green, 13 red; 3 blue, 2 red, 3 green; 10 red, 6 green, 4 blue; 11 red, 1 blue, 3 green",
            "Game 80: 3 green, 5 red, 9 blue; 3 red, 5 blue, 2 green; 5 green, 6 red, 2 blue",
            "Game 81: 2 green, 7 blue, 3 red; 9 blue, 3 red; 1 green, 17 blue, 2 red",
            "Game 82: 4 green, 8 blue, 7 red; 10 blue, 1 green, 10 red; 7 blue, 4 green, 5 red",
            "Game 83: 7 green, 4 blue, 3 red; 15 blue, 3 red, 14 green; 9 blue, 4 red, 7 green",
            "Game 84: 5 red, 5 green; 16 blue, 1 red, 7 green; 17 blue, 11 red",
            "Game 85: 7 red, 1 green, 11 blue; 13 blue, 5 green, 6 red; 11 blue, 2 green, 8 red; 5 blue, 17 red, 4 green; 12 blue, 2 green, 8 red",
            "Game 86: 3 red, 8 blue, 2 green; 15 green, 15 blue, 2 red; 18 blue, 2 red, 11 green",
            "Game 87: 1 blue; 6 red, 6 green; 1 blue, 9 red, 3 green",
            "Game 88: 10 green, 2 blue, 1 red; 7 blue, 1 green, 1 red; 9 green, 4 blue; 8 green, 1 red, 7 blue",
            "Game 89: 6 green, 2 red, 2 blue; 5 red, 3 blue, 3 green; 3 blue, 4 red, 1 green; 5 red, 4 green, 5 blue; 4 blue, 6 green, 3 red; 3 red, 1 green",
            "Game 90: 1 green, 6 blue; 1 blue, 1 red; 2 blue, 3 green; 7 green, 6 blue; 1 red, 7 green, 6 blue",
            "Game 91: 8 blue, 14 green, 5 red; 8 red, 6 green; 4 red, 7 blue, 14 green; 4 blue, 7 green; 9 blue, 7 red; 14 green, 7 blue, 4 red",
            "Game 92: 11 blue, 8 green, 6 red; 11 blue, 1 red, 11 green; 10 blue, 19 green, 5 red",
            "Game 93: 5 green, 1 red, 7 blue; 8 green, 14 blue, 2 red; 5 red, 14 blue, 7 green",
            "Game 94: 2 blue, 6 red, 3 green; 4 red, 2 green, 2 blue; 4 red, 1 blue, 1 green",
            "Game 95: 9 red, 15 green, 1 blue; 2 blue, 10 red, 18 green; 3 red, 10 green; 10 red, 17 green, 2 blue; 3 blue, 13 green, 1 red; 2 red, 2 blue, 6 green",
            "Game 96: 8 green, 1 blue; 1 blue, 1 red, 11 green; 2 green, 15 blue; 1 red, 2 green, 1 blue",
            "Game 97: 3 green, 3 blue; 5 green, 3 blue, 1 red; 5 green, 1 red, 3 blue; 1 green, 1 red, 2 blue; 2 green, 2 blue, 3 red",
            "Game 98: 6 red, 6 green, 5 blue; 19 red, 7 green; 6 green, 8 blue, 4 red; 10 green, 4 red",
            "Game 99: 9 red, 8 blue, 10 green; 3 blue, 7 green, 8 red; 6 red, 12 blue; 8 blue, 8 green, 2 red; 16 green, 14 blue, 5 red",
            "Game 100: 8 red, 13 green; 5 red, 4 green; 7 blue, 3 red, 8 green; 13 blue, 6 green; 1 blue, 8 green, 7 red; 2 red, 1 green, 16 blue"
        ];
}

public class DayTwo_One
{
    [Test]
    public void GivenGames_ThenReturnsExpectedInput()
    {
        var input = new string[] {
            "Game 1: 3 blue, 4 red; 1 red, 2 green, 6 blue; 2 green",
            "Game 2: 1 blue, 2 green; 3 green, 4 blue, 1 red; 1 green, 1 blue",
            "Game 3: 8 green, 6 blue, 20 red; 5 blue, 4 red, 13 green; 5 green, 1 red",
            "Game 4: 1 green, 3 red, 6 blue; 3 green, 6 red; 3 green, 15 blue, 14 red",
            "Game 5: 6 red, 1 blue, 3 green; 2 blue, 1 red, 2 green"
        };

        Assert.That(new DayOneBag().GetSumOfIdsFromValidGames(input), Is.EqualTo(8));
    }

    [Test]
    public void GetGameAnswer()
    {
        Console.WriteLine(new DayOneBag().GetSumOfIdsFromValidGames(DayTwoInput.Input));
    }
}

public class DayOneBag
{
    public int GetSumOfIdsFromValidGames(string[] inputs)
    {
        var validGameIds = new List<int>();
        foreach (var input in inputs)
        {
            var gameThenPulls = input.Split(':');
            var gameId = int.Parse(gameThenPulls[0].Replace("Game", ""));

            var isValidGame = true;
            var pulls = gameThenPulls[1].Split(';');
            foreach (var pull in pulls)
            {
                var cubes = pull.Split(",");

                foreach (var cube in cubes)
                {
                    var number = int.Parse(cube.Replace("green", "").Replace("blue", "").Replace("red", ""));

                    var isValid = cube switch
                    {
                        _ when cube.Contains("red") && number <= 12 => true,
                        _ when cube.Contains("green") && number <= 13 => true,
                        _ when cube.Contains("blue") && number <= 14 => true,
                        _ => false
                    };

                    isValidGame = isValidGame && isValid;
                }
            }

            if (isValidGame) validGameIds.Add(gameId);
        }

        return validGameIds.Sum();
    }
}

public class DayTwo_Two
{
    [Test]
    public void GivenGames_ThenReturnsExpectedInput()
    {
        var input = new string[] {
            "Game 1: 3 blue, 4 red; 1 red, 2 green, 6 blue; 2 green",
            "Game 2: 1 blue, 2 green; 3 green, 4 blue, 1 red; 1 green, 1 blue",
            "Game 3: 8 green, 6 blue, 20 red; 5 blue, 4 red, 13 green; 5 green, 1 red",
            "Game 4: 1 green, 3 red, 6 blue; 3 green, 6 red; 3 green, 15 blue, 14 red",
            "Game 5: 6 red, 1 blue, 3 green; 2 blue, 1 red, 2 green"
        };

        Assert.That(new DayTwoBag().GetTotalPower(input), Is.EqualTo(2286));
    }

    [Test]
    public void GetGameAnswer()
    {
        Console.WriteLine(new DayTwoBag().GetTotalPower(DayTwoInput.Input));
    }
}

public class DayTwoBag
{
    public int GetTotalPower(string[] inputs)
    {
        var totalPowers = new List<int>();
        foreach (var input in inputs)
        {
            var gameThenPulls = input.Split(':');
            var gameId = int.Parse(gameThenPulls[0].Replace("Game", ""));

            var pulls = gameThenPulls[1].Split(';');
            var greenNumber = 0;
            var redNumber = 0;
            var blueNumber = 0;

            foreach (var pull in pulls)
            {
                var cubes = pull.Split(",");

                foreach (var cube in cubes)
                {
                    var number = int.Parse(cube.Replace("green", "").Replace("blue", "").Replace("red", ""));

                    var cubeNumber = cube switch
                    {
                        _ when cube.Contains("red") && number > redNumber => redNumber = number,
                        _ when cube.Contains("green") && number > greenNumber => greenNumber = number,
                        _ when cube.Contains("blue") && number > blueNumber => blueNumber = number,
                        _ => _ = number
                    };
                }
            }

            totalPowers.Add(greenNumber * redNumber * blueNumber);
        }

        return totalPowers.Sum();
    }
}