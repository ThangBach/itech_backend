using Itech.Model.Abstract;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Itech.Model.Models
{
    [Table("Rates")]
    public class Rate
    {
        [Key]
        public int ProductId { get; set; }
        [Key]
        public int MemberId { get; set; }
        public DateTime RateDate { get; set; }
        public int RateNumber { get; set; }
        public string Comment { get; set; }

        [ForeignKey("ProductId")]
        public virtual Product Product { get; set; }
        [ForeignKey("MemberId")]
        public virtual Member Member { get; set; }
    }
}