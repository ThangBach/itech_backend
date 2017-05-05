using System;
using System.Collections.Generic;

namespace Itech.Web.Models
{
    public class ProductViewModel
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Alias { get; set; }
        public string Description { get; set; }
        public int DisplayOrder { get; set; }
        public string Image { get; set; }
        public string MoreImages { get; set; }
        public string Price { get; set; }
        public bool Status { get; set; }
        public string CreateBy { get; set; }
        public DateTime? CreateDate { get; set; }
        public string UpdateBy { get; set; }
        public DateTime? UpdateDate { get; set; }
        public bool? HomeFlag { get; set; }
        public bool? HotFlag { get; set; }
        public int ViewCount { get; set; }
        public int Quanlity { get; set; }
        public int CategoryID { get; set; }
        public virtual ProductCategoryViewModel ProductCategory { get; set; }
        public int BrandID { get; set; }    
        public virtual BrandViewModel Brand { get; set; }
        public virtual IEnumerable<OrderDetailViewModel> OrderDetails { get; set; }
        public virtual IEnumerable<PromotionDetailViewModel> PromotionDetails { get; set; }
    }
}