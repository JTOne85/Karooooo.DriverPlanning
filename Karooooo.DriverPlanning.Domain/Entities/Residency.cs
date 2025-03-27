using Karooooo.DriverPlanning.Domain.Enums;
using System.ComponentModel.DataAnnotations.Schema;

namespace Karooooo.DriverPlanning.Domain.Entities
{
    public class Residency
    {
        public int Id { get; set; }
        public ResidencyStatus ResidencyStatus { get; set; }
        public DateTime? ExpiryDate { get; set; }
        [NotMapped]
        public Nationality Nationality { get; set; }
        public Uri ResidencyDocumentUrl { get; set; }
    }
}
