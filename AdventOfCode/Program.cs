namespace AdventOfCode
{
    public class Program
    {
        static void Main()
        {
            Console.WriteLine(Day1.Question1(InputOutput.ReadFile("../../../Files/input1.txt")));
            Console.WriteLine(Day1.Question2(InputOutput.ReadFile("../../../Files/input1.txt")));
            Console.WriteLine(Day2.Question1(InputOutput.ReadFile("../../../Files/input2.txt")));
            Console.WriteLine(Day2.Question2(InputOutput.ReadFile("../../../Files/input2.txt")));
        }
    }
}