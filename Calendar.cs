using System;
using System.Collections.Generic;

namespace DayGridMonthCalendar;

public partial class Calendar
{
    public int Id { get; set; }

    public int AuctionId { get; set; }

    public virtual Auction Auction { get; set; } = null!;
}
