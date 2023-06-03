namespace Assignment3
{
    class Assistant
    {
        public ApproveClaimDelegate ApproveClaimDelegate { get; set; }
        public Assistant()
        {

        }

        public void ApproveClaim(string role, ref Claim claims)
        {
            if (role == "UnderWriter")
            {
                ApproveClaimDelegate = claims.ApproveClaimUW;
            }
            else if (role == "BankManager")
            {
                ApproveClaimDelegate = claims.ApproveClaimBM;
            }
            else if (role == "InsuranceManager")
            {
                ApproveClaimDelegate = claims.ApproveClaimUW;
                ApproveClaimDelegate += claims.ApproveClaimBM;
            }
            ApproveClaimDelegate(ref claims);
        }
    }
}
