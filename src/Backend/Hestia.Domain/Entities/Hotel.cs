namespace Hestia.Domain.Entities;

public class Hotel : EntityBase
{
    public string Name { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public string Address { get; set; } = string.Empty;
    public string City { get; set; } = string.Empty;
    public string State { get; set; } = string.Empty;
    public string Country { get; set; } = string.Empty;
    public string ZipCode { get; set; } = string.Empty;
    public string PhoneNumber { get; set; } = string.Empty;
    public string Email { get; set; } = string.Empty;
    public int Stars { get; set; }
    public decimal AverageRating { get; set; }
    public TimeSpan CheckInTime { get; set; } = new TimeSpan(14, 0, 0); 
    public TimeSpan CheckOutTime { get; set; } = new TimeSpan(11, 0, 0);

    public ICollection<Room> Rooms { get; set; } = new List<Room>();
    public ICollection<Review> Reviews { get; set; } = new List<Review>();
    public ICollection<AdditionalService> Services { get; set; } = new List<AdditionalService>();
}
