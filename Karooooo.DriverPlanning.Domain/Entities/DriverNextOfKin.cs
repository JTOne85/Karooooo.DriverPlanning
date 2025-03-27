namespace Karooooo.DriverPlanning.Domain.Entities;

public class DriverNextOfKin
{
    public int Id { get; private set; } = 0;
    public string CreatedBy { get; private set; } = "";
    public string FirstName { get; private set; } = "";
    public string LastName { get; private set; } = "";
    public string Email { get; private set; } = "";
    public string Mobile { get; private set; } = "";
    public DateTime CreatedDate { get; private set; }
}
