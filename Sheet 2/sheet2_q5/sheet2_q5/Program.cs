using System;
using System.IO;

public class sheet3_q5
{
    public static void Main()
    {
        Random random = new Random(1);
        using (TextWriter tw = new StreamWriter("D:\\Collage\\8th\\Network Programming\\Network Programming Sheets\\Sheet 2\\sheet2_q5\\output.txt"))
        {
            for (int i = 0; i < 1000; i++)
            {
                int outcome = random.Next(1, 7); 
                tw.WriteLine($"Toss outcome {outcome}");
            }
        }

        Console.WriteLine("Done");
    }
}
