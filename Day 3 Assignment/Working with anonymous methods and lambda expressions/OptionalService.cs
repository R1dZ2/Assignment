namespace Working_with_anonymous_methods_and_lambda_expressions
{
    public delegate double OptionalServiceDelegate(Dictionary<string, int> optionalServices);
    public static class OptionalService
    {
        public static double AdditionalBaggage(Dictionary<string, int> optService)
        {
            if (optService.TryGetValue("ExtraBaggage", out int ExtraBaggage))
            {
                var numberOfPieces = Math.Ceiling((double)(ExtraBaggage / 25));
                return numberOfPieces * 4000;
            }
            return 0;
        }

        public static double CabService(Dictionary<string, int> optService)
        {
            if (optService.TryGetValue("CabKms", out int CabKms))
            {
                return Math.Max(100, CabKms * 20);
            }
            return 0;
        }

        public static double TravelInsurance(Dictionary<string, int> optService)
        {
            if (optService.TryGetValue("Insurance", out int Insurance))
            {
                return Insurance * 70;
            }
            return 0;
        }
    }
}
