using System.ComponentModel.DataAnnotations;
namespace Watch_Store.Models;


public class Account
{
    public string UserId { get; set; }
    public string UserName { get; set;}
    public string PassWord { get; set;}
    public ContactStatus Status { get; set; }
}

public enum ContactStatus
{
    Submitted,
    Approved,
    Rejected
}