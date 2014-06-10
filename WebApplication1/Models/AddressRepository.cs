using System;
using System.Linq;
using System.Collections.Generic;
	
namespace WebApplication1.Models
{   
	public  class AddressRepository : EFRepository<Address>, IAddressRepository
	{

	}

	public  interface IAddressRepository : IRepository<Address>
	{

	}
}