using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S3Train.Domain
{
    public class ProductVariation:EntityBase
    {
        public string SKU { get; set; }
        public string Volume { get; set; }
        public decimal StockQuantity { get; set; }
        public decimal Price { get; set; }
        public decimal DiscountPrice { get; set; }
        public virtual Product Product { get; set; }
        public virtual ICollection<ProductImage> ProductImage { get; set; }
        public virtual ShoppingCartDetail ShoppingCartDetails { get; set; }
    }
}
