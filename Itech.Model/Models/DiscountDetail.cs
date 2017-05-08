using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Itech.Model.Models
{
    [Table("DiscountDetails")]
    public class DiscountDetail
    {
        [Key]
        [Column(Order = 1)]
        public int DiscountID { get; set; }

        [Key]
        [Column(Order = 2)]
        public int ProductCategoryID { get; set; }

        [Required]
        public string Code { get; set; }

        public bool status { get; set; }

        [ForeignKey("DiscountID")]
        public virtual Discount Discount { get; set; }

        [ForeignKey("ProductCategoryID")]
        public virtual ProductCategory ProductCategory { get; set; }
    }
}
