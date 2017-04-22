using Itech.Model.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Itech.Model.Models
{
    [Table("ProductCategories")]
    public class ProductCategory: IAuditable, ISwitchable
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }
        [Required]
        [MaxLength(256)]
        public string Name { get; set; }
        [Required]
        [MaxLength(256)]
        [Column(TypeName ="varchar")]
        public string Alias { get; set; }
        public string Description { get; set; }
        public int ParentID { get; set; }
        public int DisplayOrder { get; set; }
        public string Image { get; set; }
        public string MoreImages { get; set; }
        public decimal Price { get; set; }
        public string CreateBy { get; set; }
        public DateTime? CreateDate { get; set; }
        public bool Status { get; set; }
        public string UpdateBy { get; set; }
        public DateTime? UpdateDate { get; set; }
        public bool? HomeFlag { get; set; }
        public int ViewCount { get; set; }

        public virtual IEnumerable<Product> Products { get; set; }

    }
}