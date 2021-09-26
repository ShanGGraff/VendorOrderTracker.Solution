using System.Collections.Generic;

namespace VendorOrderTracker.Models
{
  public class Vendor
  {
    public string Name { get; set; }
    public string Description { get; set; }
    public List<Order> Order { get; set; }
    
    public Vendor(string name, string description)
    {
      Name = name;
      Description = description;
      Order = new List<Order>{};
    }

  }
}