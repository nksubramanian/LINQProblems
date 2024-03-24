namespace LINQ
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8 };
            List<int> runningSum = numbers.Select((number, index)=> numbers.Take(index+1).Sum()).ToList();
            runningSum.ForEach(number => Console.WriteLine(number));    






        }
    }
}
