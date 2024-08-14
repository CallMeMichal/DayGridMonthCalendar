namespace DayGridMonthCalendar
{
    public class EventDto
    {
        public int AuctionId { get; set; }
        public string AuctionTitle { get; set; }
        public DateTime AuctionStartDate { get; set; }
        public DateTime AuctionEndDate { get; set; }

        public object ToFullCalendarEvent()
        {
            return new
            {
                title = AuctionTitle,
                start = AuctionStartDate.ToString("yyyy-MM-ddTHH:mm:ss"),
                end = AuctionEndDate.ToString("yyyy-MM-ddTHH:mm:ss"),
            };
        }

    }
}
