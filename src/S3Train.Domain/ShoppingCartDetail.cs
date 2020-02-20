using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S3Train.Domain
{
    public class ShoppingCartDetail:EntityBase
    {
        public Guid ShoppingCart_Id { get; set; }
        public int Quantity { get; set; }
        public virtual ShoppingCart ShoppingCart { get; set; }
        public virtual ProductVariation ProductVariations { get; set; }
    }
}
