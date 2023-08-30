using AutoMapper;
using LojaShopping.ProductAPI.Data.ValueObjects;
using LojaShopping.ProductAPI.Model;

namespace LojaShopping.ProductAPI.Config
{
    public class MappingConfig
    {
        public static MapperConfiguration  RegisterMaps()
        {
            var mappingConfing = new MapperConfiguration(config => 
            {
                config.CreateMap<ProductVO, Product>();
                config.CreateMap<Product, ProductVO>();
            });
            return mappingConfing;
        }
    }
}
