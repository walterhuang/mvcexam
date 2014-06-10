using System;
using System.Linq;
using System.Collections.Generic;
	
namespace WebApplication1.Models
{   
	public  class ProductDescriptionRepository : EFRepository<ProductDescription>, IProductDescriptionRepository
	{

	}

	public  interface IProductDescriptionRepository : IRepository<ProductDescription>
	{

	}
}