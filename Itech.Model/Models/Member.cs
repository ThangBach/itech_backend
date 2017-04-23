using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Itech.Model.Models
{
    [Table("Members")]
    public class Member : IAuditable, ISwitchable
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }

        [Required]
        [MaxLength(50)]
        public string Name { get; set; }

        [Required]
        [MaxLength(30)]
        public string UserName { get; set; }

        [Required]
        [MaxLength(30)]
        public string PassWord { get; set; }

        [Required]
        public string Address { get; set; }

        public string BirthDay { get; set; }

        public string Gender { get; set; }

        public DateTime? CreateDate { get; set; }

        public string CreateBy { get; set; }

        public DateTime? UpdateDate { get; set; }

        public string UpdateBy { get; set; }

        public bool Status { get; set; }

        public int MemberCategoryID { get; set; }

        [ForeignKey("MemberCategoryID")]
        public virtual MemberCategory MemberCategory {get;set;}
    }
}