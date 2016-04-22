using System;

namespace Sixeyed.HadoopSuccinctly.Streaming.Mapper
{
    class Program
    {
        static void Main(string[] args)
        {
            string line;
            while ((line = Console.ReadLine()) != null)
            {
                line = line.Trim();
                var words = line.Split(' ');
                foreach (var word in words)
                {
                    if (word.Contains("dfs"))
                    {
                        Console.WriteLine(string.Format("{0}\t1", word));
                    }
                }                    
            }
        }
    }
}
