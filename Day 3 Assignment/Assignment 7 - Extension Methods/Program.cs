using System.Runtime.CompilerServices;

namespace Assignment_7___Extension_Methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Interview interview = new Interview("ajaY malik. k", "Software Developer", "http://www.google.com/this is my sample", "Ridhwaan",20,59902703);
            Console.WriteLine(interview.Name);
            Console.WriteLine(interview.PortfolioUrl);
        }
    }
}