namespace AdventOfCode;

class Program
{
    static void Main(string[] args)
    {
        D1Q1();
        D1Q2();
    }

    static void D1Q1()
    {
        string fileName = "../../../Files/input1.txt";

        int sum = 0;

        using (var streamReader = new StreamReader(fileName))
        {
            while (!streamReader.EndOfStream)
            {
                string line = streamReader.ReadLine() ?? string.Empty;

                int int1, int2;

                for (int i = 0; ; ++i)
                {
                    if (Char.IsDigit(line[i]))
                    {
                        int1 = line[i] - '0';
                        break;
                    }
                }

                for (int i = line.Length - 1; ; --i)
                {
                    if (Char.IsDigit(line[i]))
                    {
                        int2 = line[i] - '0';
                        break;
                    }
                }

                sum += (int1 * 10) + int2;
            }
        }

        Console.WriteLine(sum);
    }

    static void D1Q2()
    {
        string fileName = "../../../Files/input1.txt";

        string[] digits = { string.Empty, "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };

        int[] digitsLen = { 0, 3, 3, 5, 4, 4, 3, 5, 5, 4 };

        int sum = 0;

        using (var streamReader = new StreamReader(fileName))
        {
            while (!streamReader.EndOfStream)
            {
                string line = streamReader.ReadLine() ?? string.Empty;

                int int1 = 0, int2 = 0;

                for (int i = 0; ; ++i)
                {
                    bool flag = false;

                    if (Char.IsDigit(line[i]))
                    {
                        int1 = line[i] - '0';
                        break;
                    }

                    for (int j = 1; j <= 9; ++j)
                    {
                        if (i + digitsLen[j] > line.Length)
                        {
                            continue;
                        }

                        if (line.Substring(i, digitsLen[j]) == digits[j])
                        {
                            int1 = j;
                            flag = true;
                            break;
                        }
                    }

                    if (flag)
                    {
                        break;
                    }
                }

                for (int i = line.Length - 1; ; --i)
                {
                    bool flag = false;

                    if (Char.IsDigit(line[i]))
                    {
                        int2 = line[i] - '0';
                        break;
                    }

                    for (int j = 1; j <= 9; ++j)
                    {
                        if (i - digitsLen[j] < 0)
                        {
                            continue;
                        }

                        if (line.Substring(i - digitsLen[j] + 1, digitsLen[j]) == digits[j])
                        {
                            int2 = j;
                            flag = true;
                            break;
                        }
                    }

                    if (flag)
                    {
                        break;
                    }
                }

                sum += (int1 * 10) + int2;
            }
        }

        Console.WriteLine(sum);
    }
}

