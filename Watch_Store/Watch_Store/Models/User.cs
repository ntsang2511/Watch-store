using System.ComponentModel.DataAnnotations;

namespace Watch_Store.Models;

public class User
{
    public string UserId { get; set; }
    public string First_Name { get; set; }
    public string Last_Name { get; set; }
    [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
    public DateTime Date_Of_Birth { get; set; }
    public string Phone_Number { get; set; }
    public string Email { get; set; }
    public string Address { get; set; }
}
