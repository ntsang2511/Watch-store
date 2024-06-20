namespace Web_Watch_Shop.Models
{
    public class Category
    {
        public int CategoryID { get; set; }
        public string CategoryName { get; set; }
        public int ProductID { get; set; }
        public virtual Product Product { get; set; }
    }
}
