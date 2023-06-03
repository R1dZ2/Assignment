using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Memory_management_Exercise
{
    internal class PCUser : IDisposable
    {
        public PC PC { get; set; }

        public bool RequestPC(PC pc)
        {
            PC = pc;
            GC.Collect();
            GC.WaitForPendingFinalizers();

            return PC.AllocatePC();
        }

        public void ReleasePC(string method = "user")
        {
            PC.DeAllocatePC(method);
            GC.SuppressFinalize(this);
        }

        ~PCUser() 
        {
            PC.DeAllocatePC("allocator");
        }

        public void Dispose()
        {
            ReleasePC("force");
        }
    }
}
