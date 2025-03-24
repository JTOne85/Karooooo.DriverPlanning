using Karooooo.Common.Domain.SingleValueObjects;
using Karooooo.DriverPlanning.Domain.Primitives;
using System.ComponentModel.DataAnnotations.Schema;

namespace Karooooo.DriverPlanning.Domain.Entities;

public interface IAddress
{
    string? Area { get; }
    string? City { get; }
    string? Complex { get; }
    string? Country { get; }
    string? CountryCode { get; }
    FormattedAddress FormattedAddress { get; }
    Latitude? Latitude { get; }
    Longitude? Longitude { get; }
    PostalCode? PostalCode { get; }
    string? Street { get; }
    string? StreetNr { get; }
    Suburb? Suburb { get; }
    string? UnitNr { get; }
}

public class Address: IAddress, IAuditableEntity
{
    public Address() { }

    public int Id { get; set; }
    [NotMapped]
    public FormattedAddress FormattedAddress { get; private set; } = null!;
    public Suburb? Suburb { get; private set; }
    public PostalCode? PostalCode { get; private set; }
    public string? Country { get; private set; }
    public string? CountryCode { get; private set; }
    public Latitude? Latitude { get; private set; }
    public Longitude? Longitude { get; private set; }
    public string? Area { get; private set; }
    public string? City { get; private set; }
    public string? UnitNr { get; private set; }
    public string? Complex { get; private set; }
    public string? StreetNr { get; private set; }
    public string? Street { get; private set; }

    public DateTime CreatedAtUtc { get; private set; }
    public string? CreatedBy { get; private set; }
    public DateTime? UpdatedAtUtc { get; private set; }
    public string? UpdatedBy { get; private set; }

}
