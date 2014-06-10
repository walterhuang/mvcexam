namespace WebApplication1.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    
    [MetadataType(typeof(vProductAndDescriptionMetaData))]
    public partial class vProductAndDescription
    {
    }
    
    public partial class vProductAndDescriptionMetaData
    {
        [Required]
        public int ProductID { get; set; }
        
        [StringLength(50, ErrorMessage="欄位長度不得大於 50 個字元")]
        [Required]
        public string Name { get; set; }
        
        [StringLength(50, ErrorMessage="欄位長度不得大於 50 個字元")]
        [Required]
        public string ProductModel { get; set; }
        
        [StringLength(6, ErrorMessage="欄位長度不得大於 6 個字元")]
        [Required]
        public string Culture { get; set; }
        
        [StringLength(400, ErrorMessage="欄位長度不得大於 400 個字元")]
        [Required]
        public string Description { get; set; }
    }
}
