using System;
using System.Linq;
using System.Collections.Generic;
	
namespace WebApplication1.Models
{   
	public  class SalesOrderHeaderRepository : EFRepository<SalesOrderHeader>, ISalesOrderHeaderRepository
	{

	}

	public  interface ISalesOrderHeaderRepository : IRepository<SalesOrderHeader>
	{

	}
}