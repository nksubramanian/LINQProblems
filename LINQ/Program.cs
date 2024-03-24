using System.Diagnostics.CodeAnalysis;
using System.Linq;

namespace LINQ
{
    internal class Program
    {
        static void Main(string[] args)
        {

            List<int> numbers = Enumerable.Range(1, 10).ToList();
            List<int> slidingWindow = new List<int> { 1, 1, 1 };
            int windowCount = slidingWindow.Count;
            var g = numbers.Select((num, i) =>
            {

                return num + i;
            });

            var gc = Enumerable.Range(0, numbers.Count).Select(i =>
            {
                return numbers.Skip(i).Zip(slidingWindow, (a, b) => a * b).Sum();
            }).ToList();

        }
    }
}
