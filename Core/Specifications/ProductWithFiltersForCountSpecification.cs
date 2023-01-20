using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.Entities;

namespace Core.Specifications
{
    public class ProductWithFiltersForCountSpecification : BaseSpecification<Product>
    {
        public ProductWithFiltersForCountSpecification(ProductSpecParams productParams)
         : base(x=>
            (!productParams.brandId.HasValue || x.ProductBrandId == productParams.brandId) &&
            (!productParams.typeId.HasValue || x.ProductTypeId==productParams.typeId)
            )
            {
                
            }
    }
}