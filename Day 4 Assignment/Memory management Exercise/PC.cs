using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Memory_management_Exercise
{
    internal class PC
    {
        static int counter=0;
        private bool isPCSllocated;
        private int maxPC = 2;

        public bool AllocatePC()
        {
            if(counter<=maxPC)
            {
                if (isPCSllocated==false)
                {
                    isPCSllocated = true;
                }
                Console.WriteLine("PC Allocated");
                counter++;
                return true;
            }
            else
                return false;
        }

        public void DeAllocatePC(string method)
        {
            isPCSllocated=false;
            --counter;
            Console.WriteLine($"PC Deallocated by {method} ");
        }
    }
}
