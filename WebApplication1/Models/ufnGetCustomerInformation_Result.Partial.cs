namespace WebApplication1.Models
{
    using System;
    using System.ComponentModel.DataAnnotations;
    
    [MetadataType(typeof(ufnGetCustomerInformation_ResultMetaData))]
    public partial class ufnGetCustomerInformation_Result
    {
    }
    
    public partial class ufnGetCustomerInformation_ResultMetaData
    {
        [Required]
        public int CustomerID { get; set; }
        
        [StringLength(50, ErrorMessage="欄位長度不得大於 50 個字元")]
        [Required]
        public string FirstName { get; set; }
        
        [StringLength(50, ErrorMessage="欄位長度不得大於 50 個字元")]
        [Required]
        public string LastName { get; set; }
    }
}
