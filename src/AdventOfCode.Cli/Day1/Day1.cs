namespace AdventOfCode.Cli.Day1
{
    public class Day1
    {
        public static void RunPartOne()
        {
            //var input = "199\r\n200\r\n208\r\n210\r\n200\r\n207\r\n240\r\n269\r\n260\r\n263";
            var input = File.ReadAllText(Path.Combine(Directory.GetCurrentDirectory(), "Day1", "Input.txt"));

            var values = input.Split("\r\n").Select(x => Convert.ToInt32(x)).ToArray();

            var counter = 0;
            for (int i = 0; i < values.Length - 1; i++)
            {
                if (values[i] < values[i + 1])
                {
                    counter++;
                }
            }

            Console.WriteLine($"Result - Part One: {counter}");
        }

        public static void RunPartTwo()
        {
            //var input = "199\r\n200\r\n208\r\n210\r\n200\r\n207\r\n240\r\n269\r\n260\r\n263";
            var input = File.ReadAllText(Path.Combine(Directory.GetCurrentDirectory(), "Day1", "Input.txt"));

            var values = input.Split("\r\n").Select(x => Convert.ToInt32(x)).ToArray();

            var measurements = new List<int>();
            for (int i = 0; i < values.Length; i++)
            {
                if ((values.Length - i) >= 3)
                {
                    measurements.Add(values[i] + values[i + 1] + values[i + 2]);
                }
            }

            var counter = 0;
            for (int i = 0; i < measurements.Count - 1; i++)
            {
                if (measurements[i] < measurements[i + 1])
                {
                    counter++;
                }
            }

            Console.WriteLine($"Result - Part Two: {counter}");
        }
    }
}
