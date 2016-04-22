using System;

namespace Sixeyed.HadoopSuccinctly.Streaming.Reducer
{
    class Program
    {
        static void Main(string[] args)
        {
            string lastMatch = null;
            int totalCount = 0;
            string line;

            while ((line = Console.ReadLine()) != null)
            {
                line = line.Trim();
                var parts = line.Split('\t');
                var match = parts[0];
                var count = int.Parse(parts[1]);
                
                if (lastMatch == null)
                {
                    lastMatch = match;
                }

                if (lastMatch == match)
                {
                    totalCount += count;
                }
                else
                {
                    Console.WriteLine(string.Format("{0}\t{1}", lastMatch, totalCount));
                    totalCount = 1;
                    lastMatch = match;
                }
            }

            Console.WriteLine(string.Format("{0}\t{1}", lastMatch, totalCount));
        }
    }
}
