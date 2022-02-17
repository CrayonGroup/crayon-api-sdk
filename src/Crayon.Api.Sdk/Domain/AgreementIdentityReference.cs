namespace Crayon.Api.Sdk.Domain
{
    public class AgreementIdentityReference
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string AgreementNumber { get; set; }
        public decimal CommitmentLevel { get; set; }
        public bool IsCustomCommitment { get; set; }
    }
}
