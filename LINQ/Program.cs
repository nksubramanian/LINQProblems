using System.Diagnostics.CodeAnalysis;
using System.Linq;

namespace LINQ
{
    internal class Program
    {
        static void Main(string[] args)
        {

            List<int> vec1 = Enumerable.Range(1, 3).ToList();
            List<int> vec2 = Enumerable.Range(7, 3).ToList();
            var ans = vec1.Zip(vec2, (a,b)=>a*b).Sum();





        }
    }
}
