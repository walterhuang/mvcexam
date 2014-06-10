using System;
using System.Linq;
using System.Collections.Generic;
	
namespace WebApplication1.Models
{   
	public  class ProductModelRepository : EFRepository<ProductModel>, IProductModelRepository
	{

	}

	public  interface IProductModelRepository : IRepository<ProductModel>
	{

	}
}