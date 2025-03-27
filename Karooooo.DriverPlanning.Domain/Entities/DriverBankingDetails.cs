namespace Karooooo.DriverPlanning.Domain.Entities;

public class DriverBankingDetails
{
    public int Id { get; set; }
    public string BankName { get; set; }
    public string BranchCode { get; set; }
    public string AccountNumber { get; set; }
    public Uri ProofOfBankingDetailsUrl { get; set; }

}