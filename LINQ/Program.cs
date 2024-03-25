using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Net.WebSockets;

namespace LINQ
{
    internal class Program
    {

        

        static void Main(string[] args)
        {
            List<int> a = new List<int> { 1, 2, 3, 4, 5, 6, 7};
            List<int> b = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8 };
            List<int> c = new List<int> { };
            IEnumerable<int> f = a.Add(c);
            var g =f.ToList();
            var h = Enumerable.Repeat(0, 10);

            List<int> answer = 4.Multiply(a).ToList();

            



        }
    }
}
