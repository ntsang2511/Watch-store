namespace Web_Watch_Shop.Models
{
    public class Product
    {
        public int ProductID { get; set; }

        public virtual ICollection<Product_Detail>? Product_Details { get; set; }
        
    }
}
