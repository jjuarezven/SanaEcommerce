using AutoMapper;
using SanaEcommerce.Core.Models;
using SanaEcommerce.Web.ViewModel;

namespace SanaEcommerce.Web.MappingConfigurations
{
    public class ProductProfile : Profile
    {
        public ProductProfile()
        {
            CreateMap<Product, ProductViewModel>();
        }
    }
}
