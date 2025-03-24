using Karooooo.AccessManagement.Domain.Primitives;
using Karooooo.Common.Domain.Enums;
using Karooooo.Common.Domain.Uids;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Karooooo.DriverPlanning.Domain.Entities;

public class Driver: AggregateRoot<DriverUid>, IDomainEventData
{
    private Driver(DriverUid uid) : base(uid)
    {
        //Labels = _Labels.AsReadOnly();
    }

    public int Id { get; private set; }
    public int UserId { get; private set; }
    public int? AddressId { get; private set; }
    public int? VendorId { get; private set; }
    public string? V2vehicleId { get; private set; }
    public string? UniqueDeviceIdentifier { get; private set; }
    public string? ProfileUrl { get; private set; }
    public string? Bank { get; private set; }
    public string? BranchCode { get; private set; }
    public string? AccountNumber { get; private set; }
    public Fleet? Fleet { get; private set; }
    public bool IsActivated { get; private set; }
    public bool CanSeeEarnings { get; private set; }
    public string[]? Labels { get; private set; }

    public string? VehicleVinNumber { get; private set; }
    public string? VehicleLicensePlateNumber { get; private set; }
    public DateOnly? VehicleLicenseExpiryDate { get; private set; }
    public string? VehicleMake { get; private set; }
    public string? VehicleModel { get; private set; }
    public string? VehicleColour { get; private set; }
    public string? VehiclePhotoFrontUrl { get; private set; }
    public string? VehiclePhotoSideUrl { get; private set; }
    public string? VehiclePhotoBackUrl { get; private set; }
    public string? IdentificationType { get; private set; }
    public string? IdentificationNumber { get; private set; }
    public DateOnly? IdentificationExpiryDate { get; private set; }
    public string? Gender { get; private set; }
    public DateOnly? DriversLicenseExpiryDate { get; private set; }
    public string? Nationality { get; private set; }
    public bool IsForeignNational { get; private set; }
    public string? Race { get; private set; }
    public string? PhoneModel { get; private set; }
    public bool IsDeleted { get; private set; }

    public virtual User User { get; private set; } = null!;
    public virtual Address? Address { get; private set; }
    public virtual Vendor? Vendor { get; private set; } = null!;
}
