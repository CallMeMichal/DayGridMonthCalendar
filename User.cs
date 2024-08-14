namespace DayGridMonthCalendar;

public partial class User
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public string Surname { get; set; } = null!;

    public string Email { get; set; } = null!;

    public virtual ICollection<Auction> Auctions { get; set; } = new List<Auction>();

    public virtual ICollection<Auction> Auctions1 { get; set; } = new List<Auction>();

    public virtual ICollection<Auction> AuctionsNavigation { get; set; } = new List<Auction>();
}
