namespace AdventOfCode.Cli.Day3
{
    public class Day3
    {
        public static void RunPartOne()
        {
            var input = File.ReadAllText(Path.Combine(Directory.GetCurrentDirectory(), "Day3", "Input.txt"));
            var values = input.Split("\r\n").Select(x => x.ToCharArray()).ToList();

            var bitsGamma = "";
            var bitsEpsilon = "";

            var binaryLength = values[0].Length;
            for (int i = 0; i < binaryLength; i++)
            {
                var lowCount = 0;
                var highCount = 0;
                foreach (var bits in values)
                {
                    if (Convert.ToInt32(bits[i].ToString()) == 0)
                    {
                        lowCount++;
                    }
                    else
                    {
                        highCount++;
                    }
                }

                if (highCount > lowCount)
                {
                    bitsGamma += "1";
                    bitsEpsilon += "0";
                }
                else
                {
                    bitsGamma += "0";
                    bitsEpsilon += "1";
                }
            }

            var gamma = Convert.ToInt32(bitsGamma, 2);
            var epsilon = Convert.ToInt32(bitsEpsilon, 2);

            Console.WriteLine($"Results - Part One: {gamma * epsilon}");
        }

        public static void RunPartTwo()
        {
            Console.WriteLine();
        }
    }
}
