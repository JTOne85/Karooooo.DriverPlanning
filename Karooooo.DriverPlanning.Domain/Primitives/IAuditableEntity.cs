using System.ComponentModel.DataAnnotations.Schema;

namespace Karooooo.DriverPlanning.Domain.Primitives
{
    public interface IAuditableEntity
    {
        DateTime CreatedAtUtc { get; }

        [Column(TypeName = "varchar(100)")]
        string? CreatedBy { get; }

        DateTime? UpdatedAtUtc { get; }

        [Column(TypeName = "varchar(100)")]
        string? UpdatedBy { get; }
    }
}
