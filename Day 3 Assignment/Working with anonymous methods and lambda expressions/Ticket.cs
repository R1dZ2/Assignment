namespace Working_with_anonymous_methods_and_lambda_expressions
{
    public class Ticket
    {
        private static long nextTicketNumber;

        public string From { get; }
        public int NoOfPassengers { get; }
        public Dictionary<string, int> OptionalServices { get; set; }
        public long TicketNumber { get; }
        public string To { get; }
        public double TotalFare { get; set; }

        static Ticket()
        {
            nextTicketNumber = 10000;
        }

        public Ticket(string from, string to, int noOfPassengers, double fare) : base()
        {
            TicketNumber = nextTicketNumber++;

            From = from;
            To = to;
            NoOfPassengers = noOfPassengers;
            TotalFare = fare;

            OptionalServices = new Dictionary<string, int>
            {
                { "CabKms", 0 },
                {"Insurance", 0 },
                {"ExtraBaggage", 0 }
            };

        }

        public double UpdateTotalFare(OptionalServiceDelegate optDelegate)
        {
            TotalFare += optDelegate(OptionalServices);
            return TotalFare;
        }
    }
}
