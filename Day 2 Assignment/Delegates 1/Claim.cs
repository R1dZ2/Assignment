using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3
{
    public delegate void ApproveClaimDelegate(ref Claim claims);

    public class Claim
    {
        public int ClaimId { get; set; }
        public string CommentBM { get; set; }
        public string CommentUW { get; set; }
        public int InsuranceId { get; set; }
        public int NoOfProofs { get; set; }

        public Claim()
        {

        }

        public Claim(int claimId, int insuranceId,int noOfProofs) :base()
        {
            ClaimId = claimId;
            InsuranceId = insuranceId;
            NoOfProofs = noOfProofs;
        }

        public void ApproveClaimUW(ref Claim claim)
        {
            if (NoOfProofs > 3)
            {
                CommentUW = "Approved";
            }
            else
                CommentUW = "Rejected";
        }

        public void ApproveClaimBM(ref Claim claim)
        {
            if (CommentUW == "Approved")
            {
                CommentBM = "Approved";
            }
            else if (CommentUW == "Rejected")
            {
                CommentBM = "Rejected";
            }
            else
                CommentBM = "NA";
        }
    }
}
