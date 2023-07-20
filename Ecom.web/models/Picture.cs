namespace Ecom.web.models
{
    public class Picture
    {
        public int Id { get; set; }

        public string ProductFileName { get; set; }

        public int ProductId { get; set; }

        public Product Product { get; set; }
    }
}