namespace DriveSafe.Domain.Publishing.Models.Entities;

public class Rent : BaseModel
{
    public string Status { get; set; }
    public DateOnly StartDate { get; set; }
    public DateOnly EndDate { get; set; }
    public int VehicleId { get; set; }

}