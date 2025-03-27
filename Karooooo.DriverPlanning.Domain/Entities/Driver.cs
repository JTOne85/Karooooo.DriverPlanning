using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Karooooo.DriverPlanning.Domain.Entities;

public class Driver
{
    public int Id { get; private set; }
    public int UserId { get; private set; }
    public int? VendorId { get; set; }
    public string Uid { get; set; }
    public int DriverDetailsId { get; set; }
    public int DriverNextOfKinId { get; set; }
    public int DriverIdentificationId { get; set; }
    public int DriverVehcileId { get; set; }
    public int DriverLisenceId { get; set; }
    public int DriverAddressId { get; set; }
    public int DriverBankingDetailsId { get; set; }

    public virtual DriverDetails? DriverDetails { get; private set; }
    public virtual DriverNextOfKin? NextOfKin { get; set; }
    public virtual DriverIdentification? DriverIdentification { get; set; }
    public virtual DriverVehicle? DriverVehicle { get; set; }
    public virtual DriverLicense? DriverLicense { get; set; }
    public virtual DriverAddress? DriverAddress { get; set; }
    public virtual DriverBankingDetails? DriverBankingDetails { get; set; }

}
