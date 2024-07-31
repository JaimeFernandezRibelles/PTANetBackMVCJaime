using Alicunde.Domain.Abstractions;

namespace Alicunde.Domain.Entities.Fees;

public sealed class Fee : Entity
{
    public string Country { get; set; }
    public int HourlyImbalanceFee { get; set; }
    public int ImbalanceFee { get; set; }
    public int PeakLoadFee { get; set; }
    public string Timestamp { get; set; }
    public string TimestampUTC { get; set; }
    public int VolumeFee { get; set; }
    public int WeeklyFee { get; set; }

    public Fee(Guid id, string country, int hourlyImbalanceFee, int imbalanceFee,
        int peakLoadFee, string timestamp, string timestampUTC, int volumeFee, int weeklyFee) : base(id)
    {
        Country = country;
        HourlyImbalanceFee = hourlyImbalanceFee;
        ImbalanceFee = imbalanceFee;
        PeakLoadFee = peakLoadFee;
        Timestamp = timestamp;
        TimestampUTC = timestampUTC;
        VolumeFee = volumeFee;
        WeeklyFee = weeklyFee;
    }
}