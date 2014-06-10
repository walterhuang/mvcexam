namespace WebApplication1.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    
    [MetadataType(typeof(vGetAllCategoriesMetaData))]
    public partial class vGetAllCategories
    {
    }
    
    public partial class vGetAllCategoriesMetaData
    {
        
        [StringLength(50, ErrorMessage="欄位長度不得大於 50 個字元")]
        [Required]
        public string ParentProductCategoryName { get; set; }
        
        [StringLength(50, ErrorMessage="欄位長度不得大於 50 個字元")]
        public string ProductCategoryName { get; set; }
        public Nullable<int> ProductCategoryID { get; set; }
    }
}
