using System.Collections.Generic;

namespace VendorTracker.Models
{
  public class Order
  {
    public string Title { get; set; }
    public string Description { get; set; }
    public int Id { get; }
    public int Price { get; set; }
    public string Date { get; set; } 
  }
}