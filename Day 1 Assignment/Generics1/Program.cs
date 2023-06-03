using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    class Program
    {
        static void Main(string[] args)
        {
            Agent agent = new Agent();

            Insurance insuranceOne = new Insurance("I001","GFA",1,2000,4000);
            Insurance insuranceTwo =new Insurance("I002", "Phoenix", 1, 4000, 8000);
            Insurance insuranceThree = new Insurance("I001", "GFA", 1, 2900, 4000);
            Insurance insuranceFour = new Insurance("I003", "SWAN", 2, 3500, 6000);

            agent.AddPolicy(insuranceOne);
            agent.AddPolicy(insuranceTwo);
            agent.AddPolicy(insuranceThree);
            agent.Display();

            agent.SearchPolicy("I001");

            agent.AddPolicy(insuranceFour);
            agent.Display();

            agent.DeletePolicy("I003");
            agent.Display();
        }
    }
}
