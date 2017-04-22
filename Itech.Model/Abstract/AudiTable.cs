using System;
using System.ComponentModel.DataAnnotations;

namespace Itech.Model.Models
{
    public abstract class Auditable : IAuditable
    {
        [MaxLength(256)]
        public string CreateBy { get; set; }

        public DateTime? CreateDate { get; set; }

        [MaxLength(256)]
        public string UpdateBy { get; set; }

        public DateTime? UpdateDate { get; set; }
    }
}