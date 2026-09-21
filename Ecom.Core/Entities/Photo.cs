using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Ecom.Core.Entities
{
    public class Photo : BaseEntity<int>
    {
        public string PhotoName { get; set; } = string.Empty;

        public virtual Product Product { get; set; } 

        [ForeignKey(nameof(ProductId))]
        public int ProductId { get; set; }

    }
}
