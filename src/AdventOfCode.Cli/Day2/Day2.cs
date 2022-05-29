namespace AdventOfCode.Cli.Day2
{
    public class Day2
    {
        public static void RunPartOne()
        {
            var input = File.ReadAllText(Path.Combine(Directory.GetCurrentDirectory(), "Day2", "Input.txt"));
            var lines = input.Split("\r\n");

            var horizontal = 0;
            var depth = 0;

            foreach (var line in lines)
            {
                var values = line.Split(' ');

                switch (values[0])
                {
                    case "forward":
                        horizontal += Convert.ToInt32(values[1]);
                        break;
                    case "up":
                        depth -= Convert.ToInt32(values[1]);
                        break;
                    case "down":
                        depth += Convert.ToInt32(values[1]);
                        break;
                    default:
                        break;
                }
            }

            Console.WriteLine($"Results - Part One: {horizontal * depth}");
        }

        public static void RunPartTwo()
        {
            var input = File.ReadAllText(Path.Combine(Directory.GetCurrentDirectory(), "Day2", "Input.txt"));
            var lines = input.Split("\r\n");

            var horizontal = 0;
            var depth = 0;
            var aim = 0;

            foreach (var line in lines)
            {
                var values = line.Split(' ');

                switch (values[0])
                {
                    case "forward":
                        horizontal += Convert.ToInt32(values[1]);
                        depth += aim * Convert.ToInt32(values[1]);
                        break;
                    case "up":
                        aim -= Convert.ToInt32(values[1]);
                        break;
                    case "down":
                        aim += Convert.ToInt32(values[1]);
                        break;
                    default:
                        break;
                }
            }

            Console.WriteLine($"Results - Part Two: {horizontal * depth}");
        }
    }
}
