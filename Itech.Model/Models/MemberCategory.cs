using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Itech.Model.Models
{
    [Table("MemberCategories")]
    public class MemberCategory
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }

        [Required]
        [MaxLength(50)]
        public string Name { get; set; }

        public virtual IEnumerable<Member> Members { get; set; }
    }
}