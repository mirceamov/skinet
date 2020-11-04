using System;
using System.Linq.Expressions;
using Core.Entities;

namespace Core.Specification
{
    public class ProductsWithTypesAndBrandsSpecification : BaseSpecification<Product>
    {
        public ProductsWithTypesAndBrandsSpecification()
        {
            AddInclude(prod => prod.ProductType);
            AddInclude(prod => prod.ProductBrand);
        }

        public ProductsWithTypesAndBrandsSpecification(int id) 
            : base(prod => prod.Id == id)
        {
            AddInclude(prod => prod.ProductType);
            AddInclude(prod => prod.ProductBrand);
        }
    }
}