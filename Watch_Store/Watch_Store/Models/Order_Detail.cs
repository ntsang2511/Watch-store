namespace Web_Watch_Shop.Models
{
    public class Order_Detail
    {
        public int Order_DetailID { get; set; } 
        public int ProductID { get; set; }
        public int CheckOutID { get; set; }
        public Product Product { get; set; }
        public CheckOut CheckOut { get; set; }
        public virtual ICollection<Order>? Orders { get; set; }
        
    }
}
