namespace AdventOfCode
{
	public class InputOutput
	{
        public static List<string> ReadFile(string fileName)
        {
            List<string> file = new();

            using (var streamReader = new StreamReader(fileName))
            {
                while (!streamReader.EndOfStream)
                {
                    string line = streamReader.ReadLine() ?? string.Empty;

                    file.Add(line);
                }
            }

            return file;
        }
	}
}