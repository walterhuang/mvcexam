namespace WebApplication1.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    
    [MetadataType(typeof(CustomerAddressMetaData))]
    public partial class CustomerAddress
    {
    }
    
    public partial class CustomerAddressMetaData
    {
        [Required]
        public int CustomerID { get; set; }
        [Required]
        public int AddressID { get; set; }
        
        [StringLength(50, ErrorMessage="欄位長度不得大於 50 個字元")]
        [Required]
        public string AddressType { get; set; }
        [Required]
        public System.Guid rowguid { get; set; }
        [Required]
        public System.DateTime ModifiedDate { get; set; }
    
        public virtual Address Address { get; set; }
        public virtual Customer Customer { get; set; }
    }
}
