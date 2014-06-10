using System;
using System.Linq;
using System.Collections.Generic;
	
namespace WebApplication1.Models
{   
	public  class SalesOrderDetailRepository : EFRepository<SalesOrderDetail>, ISalesOrderDetailRepository
	{

	}

	public  interface ISalesOrderDetailRepository : IRepository<SalesOrderDetail>
	{

	}
}