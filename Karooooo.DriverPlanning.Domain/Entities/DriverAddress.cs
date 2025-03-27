namespace Karooooo.DriverPlanning.Domain.Entities;

public class DriverAddress
{
    public int Id { get; set; }
    public string FormattedAddress { get; set; }
    public string Suburb { get; set; }
    public string PostalCode { get; set; }

    public string Country { get; set; }
    public string CountryCode { get; set; }
    public string Area { get; set; }
    public string City { get; set; }
    public string Complex { get; set; }

    public string Street { get; set; }
    public string StreetNr { get; set; }
    public string UnitNr { get; set; }
    public string CreatedBy { get; set; }
    public string CreatedOn { get; set; }
    public string UpdatedBy { get; set; }
    public string UpdatedOn { get; set; }
    public Uri ProofOfAddressUrl { get; set; }
}
