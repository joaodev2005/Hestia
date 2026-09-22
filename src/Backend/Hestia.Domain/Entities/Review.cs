namespace Hestia.Domain.Entities;

public class Review : EntityBase
{
    public Guid BookingId { get; set; }
    public Booking Booking { get; set; } = null!;

    public Guid UserId { get; set; }
    public User User { get; set; } = null!;

    public Guid HotelId { get; set; }
    public Hotel Hotel { get; set; } = null!;

    public int Rating { get; set; }
    public string? Comment { get; set; }
}