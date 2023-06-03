using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    class Agent
    {
        public List<Insurance> InsuranceList { get; set; }
        SortedList<string, Insurance> SortedInsuranceList { get; set; }

        public Agent()
        {
            SortedInsuranceList = new SortedList<string, Insurance>();
            InsuranceList = SortedInsuranceList.Values.ToList();
        }

        public List<Insurance> AddPolicy(Insurance obj)
        {
            if (InsuranceList.Count == 0)
            {
                SortedInsuranceList.Add(obj.InsuranceId, obj);
                InsuranceList = SortedInsuranceList.Values.ToList();
            }
            else if (!SortedInsuranceList.ContainsKey(obj.InsuranceId))
            {
                SortedInsuranceList.Add(obj.InsuranceId, obj);
                InsuranceList = SortedInsuranceList.Values.ToList();
            }
            else
                Console.WriteLine("Insurance already exists");
            return InsuranceList;
        }

        public List<Insurance> DeletePolicy(string insuranceId)
        {
            if (!SearchPolicy(insuranceId).Equals(null))
            {
                SortedInsuranceList.Remove(insuranceId);
                InsuranceList = SortedInsuranceList.Values.ToList();
            }
            return InsuranceList;
        }

        public Insurance SearchPolicy(string insuranceId)
        {
            Insurance key = null;
            if (SortedInsuranceList.ContainsKey(insuranceId))
            {
                key = SortedInsuranceList[insuranceId];
                Console.WriteLine("------------------------------------------");
                Console.WriteLine("{0}\t{1}", "ID", "Name");
                Console.WriteLine("{0}\t{1}", key.InsuranceId, key.InsuranceName);
                Console.WriteLine();
            }
                return key;
        }

        public void Display()
        {
            List<Insurance> allValues = SortedInsuranceList.Values.ToList();
            Console.WriteLine("--------------");
            Console.WriteLine(" All Values ");
            foreach (Insurance item in allValues)
            {
                Console.WriteLine("{0, -10}{1, -10}{2}\t{3}", item.InsuranceId, item.InsuranceName,
                item.InsurancePolicyAmount, item.InsurancePremium);
            }
        }
    }
}
/*foreach (Insurance item in InsuranceList)
{
    if (item.InsuranceId == insuranceId)
    {
        Console.WriteLine("Insurance already exists");
        insurance = item;
        break;
    }
}*/

/*for (int i = 0; i < InsuranceList.Count; i++)
{
    if (InsuranceList[i].InsuranceId.Equals(insuranceId))
    {
        InsuranceList.RemoveAt(i);
        return InsuranceList;
    }
}*/