using Core.Entities;

namespace Core.Specifications
{
    public class ProductsWithFiltersForCountSpecification : BaseSpecification<Product>
    {
        public ProductsWithFiltersForCountSpecification(ProductsSpecParams productsSpecParams)
            : base(x => 
                (!productsSpecParams.BrandId.HasValue || x.ProductBrandId == productsSpecParams.BrandId) &&
                (!productsSpecParams.TypeId.HasValue || x.ProductTypeId == productsSpecParams.TypeId)
            )
        {
        }
    }
}