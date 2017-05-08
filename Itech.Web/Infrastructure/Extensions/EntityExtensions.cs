using Itech.Model.Models;
using Itech.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Itech.Web.Infrastructure.Extensions
{
    public static class EntityExtensions
    {
        public static void UpdateProduct(this Product product, ProductViewModel productViewModel)
        {
            product.ID = productViewModel.ID;
            product.Name = productViewModel.Name;
            product.Alias = productViewModel.Alias;
            product.Description = productViewModel.Description;
            product.DisplayOrder = productViewModel.DisplayOrder;
            product.Image = productViewModel.Image;
            product.HomeFlag = productViewModel.HomeFlag;
            product.UpdateBy = productViewModel.UpdateBy;
            product.UpdateDate = productViewModel.UpdateDate;
            product.CreateBy = productViewModel.CreateBy;
            product.CreateDate = productViewModel.CreateDate;
            product.Price = productViewModel.Price;
            product.Quanlity = productViewModel.Quanlity;
            product.ViewCount = productViewModel.ViewCount;
        }

        public static void UpdateProductCategory(this ProductCategory productCategory, ProductCategoryViewModel productCategoryViewModel)
        {
            productCategory.ID = productCategoryViewModel.ID;
            productCategory.Name = productCategoryViewModel.Name;
            productCategory.Alias = productCategoryViewModel.Alias;
            productCategory.DisplayOrder = productCategoryViewModel.DisplayOrder;
            productCategory.Image = productCategoryViewModel.Image;
            productCategory.ParentID = productCategoryViewModel.ParentID;
            productCategory.Status = productCategoryViewModel.Status;
            productCategory.UpdateBy = productCategoryViewModel.UpdateBy;
            productCategory.UpdateDate = productCategoryViewModel.UpdateDate;
            productCategory.CreateBy = productCategoryViewModel.CreateBy;
            productCategory.CreateDate = productCategoryViewModel.CreateDate;
        }
    }
}