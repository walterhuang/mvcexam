namespace WebApplication1.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    
    [MetadataType(typeof(AddressMetaData))]
    public partial class Address
    {
    }
    
    public partial class AddressMetaData
    {
        [Required]
        public int AddressID { get; set; }
        
        [StringLength(60, ErrorMessage="欄位長度不得大於 60 個字元")]
        [Required]
        public string AddressLine1 { get; set; }
        
        [StringLength(60, ErrorMessage="欄位長度不得大於 60 個字元")]
        public string AddressLine2 { get; set; }
        
        [StringLength(30, ErrorMessage="欄位長度不得大於 30 個字元")]
        [Required]
        public string City { get; set; }
        
        [StringLength(50, ErrorMessage="欄位長度不得大於 50 個字元")]
        [Required]
        public string StateProvince { get; set; }
        
        [StringLength(50, ErrorMessage="欄位長度不得大於 50 個字元")]
        [Required]
        public string CountryRegion { get; set; }
        
        [StringLength(15, ErrorMessage="欄位長度不得大於 15 個字元")]
        [Required]
        public string PostalCode { get; set; }
        [Required]
        public System.Guid rowguid { get; set; }
        [Required]
        public System.DateTime ModifiedDate { get; set; }
    
        public virtual ICollection<CustomerAddress> CustomerAddress { get; set; }
    }
}
