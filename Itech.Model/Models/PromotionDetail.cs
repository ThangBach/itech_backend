using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Itech.Model.Models
{
    [Table("PromotionDetails")]
    public class PromotionDetail
    {
        [Key]
        public int ProductID { get; set; }

        [Key]
        public int PromotionID { get; set; }

        public int Percent { get; set; }

        [ForeignKey("ProductID")]
        public virtual Product Product { get; set; }

        [ForeignKey("PromotionID")]
        public virtual Promotion Promotion { get; set; }
    }
}