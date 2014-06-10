namespace WebApplication1.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    
    [MetadataType(typeof(ProductModelProductDescriptionMetaData))]
    public partial class ProductModelProductDescription
    {
    }
    
    public partial class ProductModelProductDescriptionMetaData
    {
        [Required]
        public int ProductModelID { get; set; }
        [Required]
        public int ProductDescriptionID { get; set; }
        
        [StringLength(6, ErrorMessage="欄位長度不得大於 6 個字元")]
        [Required]
        public string Culture { get; set; }
        [Required]
        public System.Guid rowguid { get; set; }
        [Required]
        public System.DateTime ModifiedDate { get; set; }
    
        public virtual ProductDescription ProductDescription { get; set; }
        public virtual ProductModel ProductModel { get; set; }
    }
}
