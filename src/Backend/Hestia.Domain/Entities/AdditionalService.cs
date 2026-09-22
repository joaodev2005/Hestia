using Hestia.Domain.Enums;

namespace Hestia.Domain.Entities;

public class AdditionalService : EntityBase
{
    public Guid HotelId { get; set; }
    public Hotel Hotel { get; set; } = null!;

    public string Name { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public decimal Price { get; set; }
    public ServiceCategory Category { get; set; }
    public ICollection<BookingService> BookingServices { get; set; } = new List<BookingService>();
}