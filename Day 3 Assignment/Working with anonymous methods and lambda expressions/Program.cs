namespace Working_with_anonymous_methods_and_lambda_expressions
{
    public class Program
    {
        static void Main(string[] args)
        {
            Ticket ticket = new Ticket("Port Louis","Ebene", 52, 100);

            User user = new User();
            User user1 = new User();

            Console.WriteLine(user.AvailExtraService(ticket));
            Console.WriteLine(user1.AvailExtraService(ticket,20,5,20));
        
        }
    }
}