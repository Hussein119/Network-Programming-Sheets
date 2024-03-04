public class sheet2_q6
{
    public static void Main()
    {
        int[] counts = new int[7];

        using (StreamReader sr = new StreamReader("D:\\Collage\\8th\\Network Programming\\Network Programming Sheets\\Sheet 2\\sheet2_q6\\output.txt"))
        {
            string line;
            while ((line = sr.ReadLine()) != null)
            {
                int outcome = int.Parse(line.Split(' ')[2]); // Toss outcome 2
                counts[outcome]++;
            }
        }

        using (TextWriter tw = new StreamWriter("D:\\Collage\\8th\\Network Programming\\Network Programming Sheets\\Sheet 2\\sheet2_q6\\Number of numbers.txt"))
        {
            // Report the counts for each number
            for (int i = 1; i < counts.Length; i++)
            {
                Console.WriteLine($"Number of {i}s: {counts[i]}");
                tw.WriteLine($"Number of {i}s: {counts[i]}");
            }
        }
    }
}
