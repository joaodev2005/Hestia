using Hestia.Domain.Enums;

namespace Hestia.Domain.Entities;

public class PaymentInfo : EntityBase
{
    public Guid BookingId { get; set; }
    public Booking Booking { get; set; } = null!;

    public PaymentMethod Method { get; set; }
    public PaymentStatus Status { get; set; } = PaymentStatus.Pending;
    public string? CardHolderName { get; set; }
    public decimal Amount { get; set; }

    public string? TransactionId { get; set; }
    public string? GatewayToken { get; set; }

    public string? CardBrand { get; set; }
    public string? CardLast4Digits { get; set; }

    public DateTime? ProcessedAt { get; set; }
    public string? ErrorMessage { get; set; }
}
