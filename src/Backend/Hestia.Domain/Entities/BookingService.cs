namespace Hestia.Domain.Entities;

public class BookingService : EntityBase
{
    public Guid BookingId { get; set; }
    public Booking Booking { get; set; } = null!;

    public Guid AdditionalServiceId { get; set; }
    public AdditionalService AdditionalService { get; set; } = null!;

    public int Quantity { get; set; } = 1;
    public decimal UnitPrice { get; set; }   
    public decimal TotalPrice => UnitPrice * Quantity; 
}
