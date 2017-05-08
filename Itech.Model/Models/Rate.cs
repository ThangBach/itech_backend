using Itech.Model.Models;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Itech.Model.Models
{
    [Table("Rates")]
    public class Rate
    {
        [Key]
        [Column(Order = 1)]
        public int ProductId { get; set; }
        [Key]
        [Column(Order = 2)]
        public string UserName { get; set; }
        public DateTime RateDate { get; set; }
        public int RateNumber { get; set; }
        public string Comment { get; set; }
        [ForeignKey("ProductId")]
        public virtual Product Product { get; set; }
        [ForeignKey("UserName")]
        public virtual ApplicationUser User { get; set; }
    }
}