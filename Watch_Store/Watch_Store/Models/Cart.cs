namespace Watch_Store.Models
{
    public class Cart
    {
        public string CartId { get; set; }

        public string UserId { get; set; }
        public User user { get; set; }
    }
}
