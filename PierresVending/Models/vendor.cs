using System.Collections.Generic;

namespace PierresVending.Models
{
  public class Vendor
  {
    public string Description {get; set;}
    public Vendor(string description)
    {
     Description = description;
    }
  }
}