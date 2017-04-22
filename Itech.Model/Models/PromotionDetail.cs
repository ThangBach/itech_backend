using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Itech.Model.Models
{
    [Table("PromotionDetails")]
    public class PromotionDetail
    {
        [Key]
        [Column(Order = 1)]
        public int ProductID { get; set; }

        [Key]
        [Column(Order = 2)]
        public int PromotionID { get; set; }

        public int Percent { get; set; }

        [ForeignKey("ProductID")]
        public virtual Product Product { get; set; }

        [ForeignKey("PromotionID")]
        public virtual Promotion Promotion { get; set; }
    }
}