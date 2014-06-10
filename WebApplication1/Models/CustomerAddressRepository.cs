using System;
using System.Linq;
using System.Collections.Generic;
	
namespace WebApplication1.Models
{   
	public  class CustomerAddressRepository : EFRepository<CustomerAddress>, ICustomerAddressRepository
	{

	}

	public  interface ICustomerAddressRepository : IRepository<CustomerAddress>
	{

	}
}