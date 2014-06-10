namespace WebApplication1.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    
    [MetadataType(typeof(ProductDescriptionMetaData))]
    public partial class ProductDescription
    {
    }
    
    public partial class ProductDescriptionMetaData
    {
        [Required]
        public int ProductDescriptionID { get; set; }
        
        [StringLength(400, ErrorMessage="欄位長度不得大於 400 個字元")]
        [Required]
        public string Description { get; set; }
        [Required]
        public System.Guid rowguid { get; set; }
        [Required]
        public System.DateTime ModifiedDate { get; set; }
    
        public virtual ICollection<ProductModelProductDescription> ProductModelProductDescription { get; set; }
    }
}
