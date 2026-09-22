using Hestia.Domain.Enums;

namespace Hestia.Domain.Entities;

public class Booking : EntityBase
{
    public Guid UserId { get; set; }
    public User User { get; set; } = null!;
    public Guid RoomId { get; set; }
    public Room Room { get; set; } = null!;
    public DateOnly CheckIn { get; set; }
    public DateOnly CheckOut { get; set; }
    public int GuestsCount { get; set; }
    public decimal TotalPrice { get; set; }
    public BookingStatus Status { get; set; } = BookingStatus.Pending;
    public ICollection<PaymentInfo> Payments { get; set; } = new List<PaymentInfo>();
    public ICollection<BookingService> Services { get; set; } = new List<BookingService>();
    public ICollection<Review> Reviews { get; set; } = new List<Review>();
}
