using System.Collections.Generic;

namespace JobBoard.Models

{
  public class JobOpening
  {
    public string Title { get; set; }
    public string Description { get; set; }
    // public string Contact { get; set; }
    public Contact ContactInfo {get; set;}

    private static List<JobOpening> _instances = new List<JobOpening> {};

    public JobOpening(string title, string description, Contact contactinfo)
    {
      Title = title;
      Description = description;
      ContactInfo = contactinfo;
      _instances.Add(this); 
    }

    public static List<JobOpening> GetAll()
    {
      return _instances;
    }

    public static void ClearAll()
    {
      _instances.Clear();
    }
  }
}

// public class Contact
// {
//   public string Name  { get ; set; }
//   public string Email { get; set; }
//   public string Phone { get; set; }
// }