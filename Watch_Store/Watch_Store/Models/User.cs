namespace Web_Watch_Shop.Models
{
    public class User
    {
        public int UserID { get; set; }
        public string Name { get; set; }
        public DateTime DateOfBirth { get; set; }
        public int Phone {  get; set; }
        public string Email { get; set; }
        public string sex {  get; set; }
        
        public int OrderID { get; set; }
        public int CartID { get; set; } 
        public  virtual Order Order {  get; set; }
        public virtual Cart Cart { get; set; }
        public virtual ICollection<Account>? Accounts { get; set; }

    }
}
