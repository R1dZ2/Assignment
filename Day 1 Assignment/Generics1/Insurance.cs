using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    public class Insurance
    {
        public string InsuranceId { get; set; }
        public string InsuranceName { get; set; }
        public double InsurancePolicyAmount { get; set; }
        public double InsurancePremium { get; set; }
        public int InsuranceTerm { get; set; }

        public Insurance()
        {

        }

        public Insurance(string insuranceId, string insuranceName, int insuranceTerm, double amount, double premium)
        {
            InsuranceId = insuranceId;
            InsuranceName = insuranceName;
            InsuranceTerm = insuranceTerm;
            InsurancePolicyAmount = amount;
            InsurancePremium = premium;
        }
    }
}
