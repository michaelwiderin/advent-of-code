using System.Collections;

namespace AdventOfCode.Cli.Day6
{
    public class Day6
    {
        public static void Run()
        {
            //var input = "3,4,3,1,2";

            var input = File.ReadAllText(Path.Combine(Directory.GetCurrentDirectory(), "Day6", "Day6_Input.txt"));
            var integers = input.Split(',').Select(x => Convert.ToInt32(x)).ToArray();

            var lanternfishes = integers.Select(x => new Lanternfish(x)).ToList();

            for (int i = 0; i < 256; i++)
            {
                var producedFishes = new List<Lanternfish>();
                foreach (var fish in lanternfishes)
                {
                    var producedFish = fish.Produce();
                    if (producedFish is not null)
                    {
                        producedFishes.Add(producedFish);
                    }
                }

                if (producedFishes.Count > 0)
                {
                    lanternfishes.AddRange(producedFishes);
                }
            }

            Console.WriteLine($"Total: {lanternfishes.Count}");

            Console.WriteLine($"Total: {integers.Length}");
        }
    }

    public class Lanternfish
    {
        private int _timer;

        public Lanternfish(int timer = 8)
        {
            _timer = timer;
        }

        public int Timer => _timer;

        public Lanternfish Produce()
        {
            _timer--;

            if (_timer < 0)
            {
                _timer = 6;
                return new Lanternfish();
            }

            return null;
        }
    }
}
