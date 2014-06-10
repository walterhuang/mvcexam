using System;
using System.Linq;
using System.Collections.Generic;
	
namespace WebApplication1.Models
{   
	public  class ProductModelProductDescriptionRepository : EFRepository<ProductModelProductDescription>, IProductModelProductDescriptionRepository
	{

	}

	public  interface IProductModelProductDescriptionRepository : IRepository<ProductModelProductDescription>
	{

	}
}