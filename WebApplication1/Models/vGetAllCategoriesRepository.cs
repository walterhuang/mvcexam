using System;
using System.Linq;
using System.Collections.Generic;
	
namespace WebApplication1.Models
{   
	public  class vGetAllCategoriesRepository : EFRepository<vGetAllCategories>, IvGetAllCategoriesRepository
	{

	}

	public  interface IvGetAllCategoriesRepository : IRepository<vGetAllCategories>
	{

	}
}