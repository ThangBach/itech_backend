using Itech.Model.Abstract;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Itech.Model.Models
{
    [Table("Orders")]
    public class Order : ISwitchable
    {
        [Key]
        public int ID { get; set; }
        [Required]
        [MaxLength(50)]
        public string CustomerName { get; set; }
        [Required]
        [MaxLength(30)]
        public string CustomerEmail { get; set; }
        [Required]
        [MaxLength(500)]
        public string CustomerAddress { get; set; }
        [Required]
        public string CustomerMobile { get; set; }
        public string CustomerMessage { get; set; }
        public DateTime OrderDate { get; set; }
        public DateTime OrderDeliveryDate { get; set; }
        public string PaymentMethod { get; set; }
        public bool PaymentStatus { get; set; }
        public bool Status { get; set; }
    }
}