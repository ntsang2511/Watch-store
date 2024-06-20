namespace Web_Watch_Shop.Models
{
    public class Order
    {
        public int OrderID { get; set; }
        public int Order_DetailID { get; set; }
        public Order_Detail Order_Detail { get; set; }
        public virtual ICollection<User> Users { get; set; }
    }
}
