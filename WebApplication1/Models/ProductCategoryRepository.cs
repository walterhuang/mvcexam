using System;
using System.Linq;
using System.Collections.Generic;
	
namespace WebApplication1.Models
{   
	public  class ProductCategoryRepository : EFRepository<ProductCategory>, IProductCategoryRepository
	{

	}

	public  interface IProductCategoryRepository : IRepository<ProductCategory>
	{

	}
}