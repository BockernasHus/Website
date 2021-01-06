namespace Models.Entities
{
  using System;

  public class Books
  {
    public string Title { get; set; }
    public string Author { get; set; }
    public string Publisher { get; set; }
    public int Price { get; set; }
    public Conditions Condition { get; set; }
    public Types Type { get; set; }
    public DateTime PublishingYear { get; set; }
    public int NumberOfPages { get; set; }
    public int Description { get; set; }
    public string Image { get; set; }

  }
}