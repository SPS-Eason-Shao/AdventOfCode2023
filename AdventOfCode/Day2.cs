namespace AdventOfCode
{
    public class Day2
    {
        public static int Question1(List<string> input)
        {
            Dictionary<string, int> valuePairs = new()
            {
                { "red", 12 },
                { "green", 13 },
                { "blue", 14 }
            };

            int sum = 0;

            foreach (string line in input)
            {
                bool valid = true;

                List<string> split = line.Split(':').ToList();

                int gameNo = int.Parse(split[0].Substring(5, split[0].Length - 5));

                List<string> rounds = split[1].Split(';').ToList();

                foreach (string round in rounds)
                {
                    List<string> choices = round.Split(' ').ToList();

                    for (int i = 1; i < choices.Count; i += 2)
                    {
                        int ballNo = int.Parse(choices[i]);
                        string colour = choices[i + 1].Replace(",", string.Empty);

                        if (ballNo > valuePairs[colour])
                        {
                            valid = false;
                        }
                    }
                }

                if (valid)
                {
                    sum += gameNo;
                }
            }


            return sum;
        }

        public static int Question2(List<string> input)
        {
            Dictionary<string, int> valuePairs = new()
            {
                { "red", 0 },
                { "green", 1 },
                { "blue", 2 }
            };

            int sum = 0;

            foreach(string line in input)
            {
                List<int> maxNo = new() { 0, 0, 0 };

                List<string> split = line.Split(':').ToList();

                int gameNo = int.Parse(split[0].Substring(5, split[0].Length - 5));

                List<string> rounds = split[1].Split(';').ToList();

                foreach (string round in rounds)
                {
                    List<string> choices = round.Split(' ').ToList(); ;

                    for (int i = 1; i < choices.Count; i += 2)
                    {
                        int ballNo = int.Parse(choices[i]);
                        string colour = choices[i + 1].Replace(",", string.Empty);

                        maxNo[valuePairs[colour]] = ballNo > maxNo[valuePairs[colour]] ? ballNo : maxNo[valuePairs[colour]];
                    }
                }

                int power = 1;

                foreach (int i in maxNo)
                {
                    power *= i;
                }

                sum += power;
            }

            return sum;
        }
    }
}

