using System;
using System.Linq;
using System.Collections.Generic;
	
namespace WebApplication1.Models
{   
	public  class vProductAndDescriptionRepository : EFRepository<vProductAndDescription>, IvProductAndDescriptionRepository
	{

	}

	public  interface IvProductAndDescriptionRepository : IRepository<vProductAndDescription>
	{

	}
}