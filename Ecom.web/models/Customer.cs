namespace Ecom.web.models
{
    public class Customer
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Adresse1 { get; set; }

        public string Adresse2 { get; set; }

        public string City { get; set; }

        public string PostalCode { get; set; }

        public string EmailAddress { get; set; }

        public DateTime? EnteredDate { get; set; }

        public virtual ICollection<CartItem> CartItems { get; set; } = new HashSet<CartItem>();

        public virtual ICollection<Product> Products { get; set; } = new HashSet<Product>();
    }
}