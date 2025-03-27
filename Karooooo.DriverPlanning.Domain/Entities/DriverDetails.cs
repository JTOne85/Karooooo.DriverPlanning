using Karooooo.Common.Domain.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Karooooo.DriverPlanning.Domain.Entities;


public class DriverDetails
{
    public int Id { get; private set; } = 0;
    public string CreatedBy { get; private set; } = "";
    public string FirstName { get; private set; } = "";
    public string LastName { get; private set; } = "";
    public string Email { get; private set; } = "";
    public string Mobile { get; private set; } = "";
    public string PhoneModel { get; private set; } = "";
    public DateTime CreatedDate { get; private set; }
    public virtual DriverIdentification? DriverIdentification { get; private set; }

}
