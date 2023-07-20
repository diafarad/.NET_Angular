﻿namespace Ecom.web.models
{
    public class Product
    {
        public int Id { get; set; }

        public string  ProductName { get; set; }

        public string Details { get; set; }

        public decimal UnitPrice { get; set; }

        public int? UnitInStock { get; set; }

        public byte[] ProductImagePath { get; set; }

        //public int CartId { get; set; }

        public int? CategoryId { get; set; }

        //public int OrderLineId { get; set; }

        //public int? PictureId { get; set; }

        public virtual ICollection<CartItem> CartItems { get; set; }

        public virtual ICollection<Category> Category { get; set; }

        public virtual ICollection<Orderline> Orderlines { get; set; }

        public virtual ICollection<Picture> Pictures { get; set; }
    }
}