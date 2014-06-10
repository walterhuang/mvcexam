namespace WebApplication1.Models
{
	public static class RepositoryHelper
	{
		public static IUnitOfWork GetUnitOfWork()
		{
			return new EFUnitOfWork();
		}		
		
		public static AddressRepository GetAddressRepository()
		{
			var repository = new AddressRepository();
			repository.UnitOfWork = GetUnitOfWork();
			return repository;
		}

		public static AddressRepository GetAddressRepository(IUnitOfWork unitOfWork)
		{
			var repository = new AddressRepository();
			repository.UnitOfWork = unitOfWork;
			return repository;
		}		

		public static CustomerRepository GetCustomerRepository()
		{
			var repository = new CustomerRepository();
			repository.UnitOfWork = GetUnitOfWork();
			return repository;
		}

		public static CustomerRepository GetCustomerRepository(IUnitOfWork unitOfWork)
		{
			var repository = new CustomerRepository();
			repository.UnitOfWork = unitOfWork;
			return repository;
		}		

		public static CustomerAddressRepository GetCustomerAddressRepository()
		{
			var repository = new CustomerAddressRepository();
			repository.UnitOfWork = GetUnitOfWork();
			return repository;
		}

		public static CustomerAddressRepository GetCustomerAddressRepository(IUnitOfWork unitOfWork)
		{
			var repository = new CustomerAddressRepository();
			repository.UnitOfWork = unitOfWork;
			return repository;
		}		

		public static ProductRepository GetProductRepository()
		{
			var repository = new ProductRepository();
			repository.UnitOfWork = GetUnitOfWork();
			return repository;
		}

		public static ProductRepository GetProductRepository(IUnitOfWork unitOfWork)
		{
			var repository = new ProductRepository();
			repository.UnitOfWork = unitOfWork;
			return repository;
		}		

		public static ProductCategoryRepository GetProductCategoryRepository()
		{
			var repository = new ProductCategoryRepository();
			repository.UnitOfWork = GetUnitOfWork();
			return repository;
		}

		public static ProductCategoryRepository GetProductCategoryRepository(IUnitOfWork unitOfWork)
		{
			var repository = new ProductCategoryRepository();
			repository.UnitOfWork = unitOfWork;
			return repository;
		}		

		public static ProductDescriptionRepository GetProductDescriptionRepository()
		{
			var repository = new ProductDescriptionRepository();
			repository.UnitOfWork = GetUnitOfWork();
			return repository;
		}

		public static ProductDescriptionRepository GetProductDescriptionRepository(IUnitOfWork unitOfWork)
		{
			var repository = new ProductDescriptionRepository();
			repository.UnitOfWork = unitOfWork;
			return repository;
		}		

		public static ProductModelRepository GetProductModelRepository()
		{
			var repository = new ProductModelRepository();
			repository.UnitOfWork = GetUnitOfWork();
			return repository;
		}

		public static ProductModelRepository GetProductModelRepository(IUnitOfWork unitOfWork)
		{
			var repository = new ProductModelRepository();
			repository.UnitOfWork = unitOfWork;
			return repository;
		}		

		public static ProductModelProductDescriptionRepository GetProductModelProductDescriptionRepository()
		{
			var repository = new ProductModelProductDescriptionRepository();
			repository.UnitOfWork = GetUnitOfWork();
			return repository;
		}

		public static ProductModelProductDescriptionRepository GetProductModelProductDescriptionRepository(IUnitOfWork unitOfWork)
		{
			var repository = new ProductModelProductDescriptionRepository();
			repository.UnitOfWork = unitOfWork;
			return repository;
		}		

		public static SalesOrderDetailRepository GetSalesOrderDetailRepository()
		{
			var repository = new SalesOrderDetailRepository();
			repository.UnitOfWork = GetUnitOfWork();
			return repository;
		}

		public static SalesOrderDetailRepository GetSalesOrderDetailRepository(IUnitOfWork unitOfWork)
		{
			var repository = new SalesOrderDetailRepository();
			repository.UnitOfWork = unitOfWork;
			return repository;
		}		

		public static SalesOrderHeaderRepository GetSalesOrderHeaderRepository()
		{
			var repository = new SalesOrderHeaderRepository();
			repository.UnitOfWork = GetUnitOfWork();
			return repository;
		}

		public static SalesOrderHeaderRepository GetSalesOrderHeaderRepository(IUnitOfWork unitOfWork)
		{
			var repository = new SalesOrderHeaderRepository();
			repository.UnitOfWork = unitOfWork;
			return repository;
		}		

		public static vGetAllCategoriesRepository GetvGetAllCategoriesRepository()
		{
			var repository = new vGetAllCategoriesRepository();
			repository.UnitOfWork = GetUnitOfWork();
			return repository;
		}

		public static vGetAllCategoriesRepository GetvGetAllCategoriesRepository(IUnitOfWork unitOfWork)
		{
			var repository = new vGetAllCategoriesRepository();
			repository.UnitOfWork = unitOfWork;
			return repository;
		}		

		public static vProductAndDescriptionRepository GetvProductAndDescriptionRepository()
		{
			var repository = new vProductAndDescriptionRepository();
			repository.UnitOfWork = GetUnitOfWork();
			return repository;
		}

		public static vProductAndDescriptionRepository GetvProductAndDescriptionRepository(IUnitOfWork unitOfWork)
		{
			var repository = new vProductAndDescriptionRepository();
			repository.UnitOfWork = unitOfWork;
			return repository;
		}		

		public static vProductModelCatalogDescriptionRepository GetvProductModelCatalogDescriptionRepository()
		{
			var repository = new vProductModelCatalogDescriptionRepository();
			repository.UnitOfWork = GetUnitOfWork();
			return repository;
		}

		public static vProductModelCatalogDescriptionRepository GetvProductModelCatalogDescriptionRepository(IUnitOfWork unitOfWork)
		{
			var repository = new vProductModelCatalogDescriptionRepository();
			repository.UnitOfWork = unitOfWork;
			return repository;
		}		
	}
}