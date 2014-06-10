namespace WebApplication1.Models
{
    using System;
    using System.ComponentModel.DataAnnotations;
    
    [MetadataType(typeof(ufnGetAllCategories_ResultMetaData))]
    public partial class ufnGetAllCategories_Result
    {
    }
    
    public partial class ufnGetAllCategories_ResultMetaData
    {
        
        [StringLength(50, ErrorMessage="欄位長度不得大於 50 個字元")]
        public string ParentProductCategoryName { get; set; }
        
        [StringLength(50, ErrorMessage="欄位長度不得大於 50 個字元")]
        [Required]
        public string ProductCategoryName { get; set; }
        [Required]
        public int ProductCategoryID { get; set; }
    }
}
