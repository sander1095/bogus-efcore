namespace bogus_efcore;

public class Event
{
    public int Id { get; set; }
    public string Name { get; set; } = null!;
    public DateTimeOffset Date { get; set; }   
}
