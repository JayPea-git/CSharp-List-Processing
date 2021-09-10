using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListProcessingConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, int> twoTimesTable = new Dictionary<int, int>();
            List<int> keys = new List<int> { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            keys.ForEach(key => twoTimesTable.Add(key, key * 2));
            foreach (int i in twoTimesTable.Keys)
                Console.WriteLine(twoTimesTable[i]);
            Console.ReadLine();
        }

        //Initial attempt
        /*
        public List<int> DoubleInts(List<int> list)
        {
            List<int> outputList = new List<int>();

            foreach (int i in list)
                outputList.Add(i * 2);

            return outputList;
        }
        */

        //Lambda functions
        public List<int> DoubleInts(List<int> list, int factor = 2)
        {
            return list.Select(i => i * factor).ToList();
        }

        public List<int> EvenList(List<int> list, int divisor = 2)
        {
            return list.Where(i => i % divisor == 0).ToList();
        }

        public bool IsAllEven(List<int> list)
        {
            return list.All(i => i % 2 == 0);
        }

        public bool AreAnyEven(List<int> list)
        {
            return list.Any(i => i % 2 == 0);
        }

        public int Aggregate(List<int> list)
        {
            return list.Aggregate((i, j) => i + j);
        }

        public List<int> FacnyChaining(List<int> list)
        {
            // *7, +5, remove %3, remove %2
            return list
                .Select(i => i * 7)
                .Select(i => i + 5)
                .Where(i => i % 3 != 0)
                .Where(i => i % 2 != 0)
                .ToList();

            /*
            return list
                .Select(i => i * 7 * 5)
                .Where(i => i % 3 != 0 && i % 2 != 0)
                .ToList();
            */
        }

        public Dictionary<int, int> CalculateDoubles(List<int> list)
        {
            Dictionary<int, int> dictionary = new Dictionary<int, int>();
            list.ForEach(i => dictionary.Add(i, i * 2));
            return dictionary;
        }
    }
}
