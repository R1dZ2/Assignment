namespace Working_with_anonymous_methods_and_lambda_expressions
{
    public class User
    {
        public OptionalServiceDelegate optionalServiceDelegate;

        private static int nextUserId;

        public int UserId { get; }

        static User()
        {
            nextUserId = 7000;
        }

        public User()
        {
            UserId = nextUserId++;
        }

        public double AvailExtraService(Ticket ticket, int cabKms = 0, int noOfPersons = 0, int extraBaggage = 0)
        {
            if (cabKms > 0)
            {
                ticket.OptionalServices["CabKms"] = cabKms;
                optionalServiceDelegate += OptionalService.CabService;
            }

            if (noOfPersons > 0 && noOfPersons <= ticket.NoOfPassengers)
            {
                ticket.OptionalServices["Insurance"] = noOfPersons;
                optionalServiceDelegate += OptionalService.TravelInsurance;
            }

            if (extraBaggage > 0)
            {
                ticket.OptionalServices["ExtraBaggage"] = extraBaggage;
                optionalServiceDelegate += OptionalService.AdditionalBaggage;
            }

            if (ticket.OptionalServices != null)
            {
                OptionalServiceDelegate anonymousDelegate = delegate (Dictionary<string, int> optionalServices)
                {
                    double processingFee = 0;

                    foreach (var entry in optionalServices)
                    {
                        if (entry.Value > 0)
                        {
                            processingFee += 20;
                        }
                    }

                    return processingFee;
                };
                optionalServiceDelegate += anonymousDelegate;

                return ticket.UpdateTotalFare(optionalServiceDelegate);
            }
            else
            {
                return ticket.TotalFare;
            }
        }
    }
}
