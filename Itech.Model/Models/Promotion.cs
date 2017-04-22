using Itech.Model.Abstract;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Itech.Model.Models
{
    [Table("Promotions")]
    public class Promotion : IAuditable, ISwitchable
    {
        [Key]
        public int ID { get; set; }
        [Required]
        [MaxLength(500)]
        public string Name { get; set; }
        [Required]
        public DateTime StartDate { get; set; }
        [Required]
        public DateTime EndDate { get; set; }
        public string Image { get; set; }

        public DateTime? CreateDate { get; set; }

        public string CreateBy { get; set; }

        public DateTime? UpdateDate { get; set; }

        public string UpdateBy { get; set; }
        [Required]
        public bool Status { get; set; }
    }
}