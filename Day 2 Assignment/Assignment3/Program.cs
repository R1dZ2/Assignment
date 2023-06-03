using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3
{
    class Program
    {
        static void Main(string[] args)
        {
            Claim claim1 = new Claim(001, 01, 2);
            Claim claim2 = new Claim(002, 01, 5);

            Assistant assistant = new Assistant();
            assistant.ApproveClaim("UnderWriter",ref claim1);
            assistant.ApproveClaim("InsuranceManager", ref claim2);
            Console.WriteLine(claim1.CommentUW);
            Console.WriteLine(claim1.CommentBM);
            Console.WriteLine(claim2.CommentUW);
            Console.WriteLine(claim2.CommentBM);
        }
    }
}
