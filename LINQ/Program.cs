using System.Diagnostics.CodeAnalysis;
using System.Linq;

namespace LINQ
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> names = new List<string>
            {
                "a", "b", "c", "d"
            };
            var serializedNames = names.Select((x, index)=>(index+1).ToString()+" "+x).ToList();





        }
    }
}
