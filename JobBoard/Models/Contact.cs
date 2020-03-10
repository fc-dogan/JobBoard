using System.Collections.Generic;

namespace JobBoard.Models
{
  public class Contact
  {
    public string Name  { get ; set; }
    public string Email { get; set; }
    public string Phone { get; set; }

    // private static List<Contact> _instances = new List<Contact> {};

    public Contact(string name, string email, string phone)
    {
      Name = name;
      Email = email;
      Phone = phone;
      // _instances.Add(this); 
    }
    // public static List<Contact> GetAll()
    // {
    //   return _instances;
    // }
  }
}