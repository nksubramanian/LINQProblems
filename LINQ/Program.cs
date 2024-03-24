using System.Diagnostics.CodeAnalysis;
using System.Linq;

namespace LINQ
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int> { 1, 2, 3, 4 };
            int res = numbers.Aggregate((sum, val)=>sum+val);
            var runningSum = numbers.Aggregate(new List<int>(), (acc, val) =>
            {
                acc.Add(val+acc.LastOrDefault());
                return acc;
            }).ToList();





        }
    }
}
