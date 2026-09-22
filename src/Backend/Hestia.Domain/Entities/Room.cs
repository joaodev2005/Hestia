using Hestia.Domain.Enums;

namespace Hestia.Domain.Entities;

public class Room : EntityBase
{
    public Guid HotelId { get; set; }
    public Hotel Hotel { get; set; } = null!;
    public string Number { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public decimal PricePerNight { get; set; }
    public int Capacity { get; set; }
    public RoomType RoomType { get; set; }

    public ICollection<Booking> Bookings { get; set; } = new List<Booking>();
}
