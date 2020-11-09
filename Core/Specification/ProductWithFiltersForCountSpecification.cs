using Core.Entities;

namespace Core.Specification
{
    public class ProductWithFiltersForCountSpecification : BaseSpecification<Product>
    {
        public ProductWithFiltersForCountSpecification(ProductParamSpec productParam)
            : base(p => 
                (string.IsNullOrWhiteSpace(productParam.Search) || p.Name.ToLower().Contains(productParam.Search)) &&
                (!productParam.BrandId.HasValue || p.ProductBrandId == productParam.BrandId) &&
                (!productParam.TypeId.HasValue || p.ProductTypeId == productParam.TypeId))
        {            
        }
    }
}