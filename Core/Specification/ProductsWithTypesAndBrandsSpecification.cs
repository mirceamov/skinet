using System;
using System.Linq.Expressions;
using Core.Entities;

namespace Core.Specification
{
    public class ProductsWithTypesAndBrandsSpecification : BaseSpecification<Product>
    {
        public ProductsWithTypesAndBrandsSpecification(ProductParamSpec productParam) :
            base(p => 
                (string.IsNullOrWhiteSpace(productParam.Search) || p.Name.ToLower().Contains(productParam.Search)) &&
                (!productParam.BrandId.HasValue || p.ProductBrandId == productParam.BrandId) &&
                (!productParam.TypeId.HasValue || p.ProductTypeId == productParam.TypeId))
        {
            AddInclude(prod => prod.ProductType);
            AddInclude(prod => prod.ProductBrand);
            AddOrderBy(prod => prod.Name);

            if(!string.IsNullOrWhiteSpace(productParam.Sort))
            {
                switch (productParam.Sort)
                {
                    case "nameAsc":
                        AddOrderBy(prod => prod.Name);
                        break;
                    case "nameDesc":
                        AddOrderByDesc(prod => prod.Name);
                        break;
                    case "priceAsc":
                        AddOrderBy(prod => prod.Price);
                        break;
                    case "priceDesc":
                        AddOrderByDesc(prod => prod.Price);
                        break;
                    default:
                        AddOrderBy(prod => prod.Name);
                        break;
                }
            }


            AddPagination(productParam.PageSize*(productParam.PageIndex-1), productParam.PageSize);
        }

        public ProductsWithTypesAndBrandsSpecification(int id) 
            : base(prod => prod.Id == id)
        {
            AddInclude(prod => prod.ProductType);
            AddInclude(prod => prod.ProductBrand);
        }
    }
}