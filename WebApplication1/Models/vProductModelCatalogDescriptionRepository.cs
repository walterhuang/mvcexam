using System;
using System.Linq;
using System.Collections.Generic;
	
namespace WebApplication1.Models
{   
	public  class vProductModelCatalogDescriptionRepository : EFRepository<vProductModelCatalogDescription>, IvProductModelCatalogDescriptionRepository
	{

	}

	public  interface IvProductModelCatalogDescriptionRepository : IRepository<vProductModelCatalogDescription>
	{

	}
}