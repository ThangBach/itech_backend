using AutoMapper;
using Itech.Model.Models;
using Itech.Web.Models;

namespace Itech.Web.Mappings
{
    public class AutoMapperConfiguration
    {
        public static void Configure()
        {
            Mapper.CreateMap<Product, ProductViewModel>();
            Mapper.CreateMap<ProductCategory, ProductCategoryViewModel>();
            Mapper.CreateMap<Brand, BrandViewModel>();
            Mapper.CreateMap<OrderDetail, OrderDetailViewModel>();
            Mapper.CreateMap<PromotionDetail, PromotionDetailViewModel>();
        }
    }
}