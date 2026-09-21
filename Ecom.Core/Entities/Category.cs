using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Ecom.Core.Entities
{
    public class Category : BaseEntity<int>
    {
        public string Name {  get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;

        public int ProductId { get; set; }
        [ForeignKey(nameof(ProductId))]  
        public ICollection<Product> Products { get; set;  } = new List<Product>();
        


    }
}
