namespace Web_Watch_Shop.Models
{
    public class Cart
    {
        public int CartID { get; set; }
        public int Cart_DetailID { get; set; }
        public Cart_Detail CartDetail { get; set; }
        public virtual ICollection<User>? User { get; set; }
    }
}
