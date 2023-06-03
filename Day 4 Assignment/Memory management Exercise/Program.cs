namespace Memory_management_Exercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PC pc1 = new PC();
            PC pc2 = new PC();
            //User1 requests PC
            PCUser user1 = new PCUser();
            user1.RequestPC(pc1);
            //User1 forgets to release PC
            user1 = null;
            //User2 requests PC and PC is deallocated forcefully
            using (PCUser user2 = new PCUser())
            {
                user2.RequestPC(pc2);
            }
            PCUser user3 = new PCUser();
            //User3 requests PC and Allocator deallocates PC1 used by user1
            user3.RequestPC(pc1);
            //User3 releases the PC after use
            user3.RequestPC(pc1);
        }

    }
}