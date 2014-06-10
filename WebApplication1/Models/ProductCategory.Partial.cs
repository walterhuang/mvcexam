namespace WebApplication1.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    
    [MetadataType(typeof(ProductCategoryMetaData))]
    public partial class ProductCategory
    {
    }
    
    public partial class ProductCategoryMetaData
    {
        [Required]
        public int ProductCategoryID { get; set; }
        public Nullable<int> ParentProductCategoryID { get; set; }
        
        [StringLength(50, ErrorMessage="欄位長度不得大於 50 個字元")]
        [Required]
        public string Name { get; set; }
        [Required]
        public System.Guid rowguid { get; set; }
        [Required]
        public System.DateTime ModifiedDate { get; set; }
    
        public virtual ICollection<Product> Product { get; set; }
        public virtual ICollection<ProductCategory> ProductCategory1 { get; set; }
        public virtual ProductCategory ProductCategory2 { get; set; }
    }
}
