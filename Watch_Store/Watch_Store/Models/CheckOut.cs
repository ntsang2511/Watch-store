namespace Web_Watch_Shop.Models
{
    public class CheckOut
    {
        public int CheckoutID { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public int Phone { get; set; }
        public int ZipCode { get; set; }
        public string Sex { get; set; }
        public string Email { get; set; }
        public string DeliveryMethod { get; set; }
        public virtual ICollection<Order_Detail>? Order_Details { get; set; }
    }
}
