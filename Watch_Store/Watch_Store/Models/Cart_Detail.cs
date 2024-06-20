namespace Web_Watch_Shop.Models
{
    public class Cart_Detail
    {
        public int Cart_DetailID {  get; set; }
        public Product Product { get; set; }
        public virtual ICollection<Cart>? Carts { get; set; }
    }
}
