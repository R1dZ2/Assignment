namespace Assignment6___Extension_Method
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Bill bill = new Bill("B1",2,500);
            Restaurant restaurant = new Restaurant();
            Console.WriteLine(restaurant.CalculateAmount(bill));
        }
    }
}