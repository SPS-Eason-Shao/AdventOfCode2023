namespace AdventOfCode
{
    public class Day1
    {
        public static int Question1(List<string> input)
        {
            int sum = 0;

            foreach (string line in input)
            {
                int int1 = -1, int2 = -1;

                for (int i = 0; i < line.Length; ++i)
                {
                    if (char.IsDigit(line[i]))
                    {
                        int1 = (int1 == -1) ? line[i] - '0' : int1;
                        int2 = line[i] - '0';
                    }
                }

                sum += (int1 * 10) + int2;
            }

            return sum;
        }

        public static int Question2(List<string> input)
        {
            List<string> strings = new()
            {
                string.Empty, "one", "two", "three", "four", "five", "six", "seven", "eight", "nine"
            };

            List<int> lengths = new();

            foreach(string str in strings)
            {
                lengths.Add(str.Length);
            }

            int sum = 0;

            foreach (string line in input)
            {
                int int1 = -1, int2 = -1;

                for (int i = 0; i < line.Length; ++i)
                {
                    if (char.IsDigit(line[i]))
                    {
                        int1 = int1 == -1 ? line[i] - '0' : int1;
                        int2 = line[i] - '0';
                    }

                    for (int j = 1; j <= 9; ++j)
                    {
                        if (i + lengths[j] > line.Length)
                        {
                            continue;
                        }

                        if (line.Substring(i, lengths[j]) == strings[j])
                        {
                            int1 = int1 == -1 ? j : int1;
                            int2 = j;
                        }
                    }
                }

                sum += (int1 * 10) + int2;
            }

            return sum;
        }
    }
}