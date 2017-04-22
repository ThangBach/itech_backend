using Itech.Model.Abstract;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Itech.Model.Models
{
    [Table("Products")]
    public class Product : IAuditable, ISwitchable
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
        [Required]
        public string Description { get; set; }
        public int DisplayOrder { get; set; }
        [Required]
        public string Image { get; set; }
        public string MoreImages { get; set; }
        public decimal Price { get; set; }
        public string CreateBy { get; set; }
        public DateTime? CreateDate { get; set; }
        public bool Status { get; set; }
        public string UpdateBy { get; set; }
        public DateTime? UpdateDate { get; set; }
        public bool? HomeFlag { get; set; }
        public bool? HotFlag { get; set; }
        public int ViewCount { get; set; }
        public int Quanlity { get; set; }
        [Required]
        public int CategoryID { get; set; }

        [ForeignKey("CategoryID")]
        public virtual ProductCategory ProductCategory { get; set; }
    }
}