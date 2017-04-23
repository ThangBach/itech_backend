using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Itech.Model.Models
{
    [Table("Menus")]
    public class Menu
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string URL { get; set; }
        public int? DisplayOrder { get; set; }
        public string Target { get; set; }
        [Required]
        public bool Status { get; set; }
        [Required]
        public int GroupMenuID { get; set; }

        [ForeignKey("GroupMenuID")]
        public virtual MenuGroup MenuGroup { get; set; }

    }
}
