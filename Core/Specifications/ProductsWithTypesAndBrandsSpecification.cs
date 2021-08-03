using System;
using System.Linq.Expressions;
using Core.Entities;

namespace Core.Specifications
{
    public class ProductsWithTypesAndBrandsSpecification : BaseSpecification<Product>
    {
        public ProductsWithTypesAndBrandsSpecification(ProductsSpecParams productsSpecParams) 
            : base(x => 
                (!string.IsNullOrEmpty(productsSpecParams.Search) || x.Name.ToLower().Contains(productsSpecParams.Search)) &&
                (!productsSpecParams.BrandId.HasValue || x.ProductBrandId == productsSpecParams.BrandId) &&
                (!productsSpecParams.TypeId.HasValue || x.ProductTypeId == productsSpecParams.TypeId)
            )
        {
            AddInclude(p => p.ProductType);
            AddInclude(p => p.ProductBrand);
            AddOrderBy(p => p.Name);
            ApplyPaging(productsSpecParams.PageSize * (productsSpecParams.PageIndex - 1), productsSpecParams.PageSize);

            if (!string.IsNullOrEmpty(productsSpecParams.Sort))
            {
                switch (productsSpecParams.Sort)
                {
                    case "priceAsc":
                        AddOrderBy(p => p.Price);
                        break;
                    case "priceDesc":
                        AddOrderByDescending(p => p.Price);
                        break;
                    default:
                        AddOrderBy(p => p.Name);
                        break;
                }
            }
        }

        public ProductsWithTypesAndBrandsSpecification(int id) : base(p => p.Id == id)
        {
            AddInclude(p => p.ProductType);
            AddInclude(p => p.ProductBrand);
        }
    }
}