namespace WebApplication1.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    
    [MetadataType(typeof(SalesOrderHeaderMetaData))]
    public partial class SalesOrderHeader
    {
    }
    
    public partial class SalesOrderHeaderMetaData
    {
        [Required]
        public int SalesOrderID { get; set; }
        [Required]
        public byte RevisionNumber { get; set; }
        [Required]
        public System.DateTime OrderDate { get; set; }
        [Required]
        public System.DateTime DueDate { get; set; }
        public Nullable<System.DateTime> ShipDate { get; set; }
        [Required]
        public byte Status { get; set; }
        [Required]
        public bool OnlineOrderFlag { get; set; }
        
        [StringLength(25, ErrorMessage="欄位長度不得大於 25 個字元")]
        [Required]
        public string SalesOrderNumber { get; set; }
        
        [StringLength(25, ErrorMessage="欄位長度不得大於 25 個字元")]
        public string PurchaseOrderNumber { get; set; }
        
        [StringLength(15, ErrorMessage="欄位長度不得大於 15 個字元")]
        public string AccountNumber { get; set; }
        [Required]
        public int CustomerID { get; set; }
        public Nullable<int> ShipToAddressID { get; set; }
        public Nullable<int> BillToAddressID { get; set; }
        
        [StringLength(50, ErrorMessage="欄位長度不得大於 50 個字元")]
        [Required]
        public string ShipMethod { get; set; }
        
        [StringLength(15, ErrorMessage="欄位長度不得大於 15 個字元")]
        public string CreditCardApprovalCode { get; set; }
        [Required]
        public decimal SubTotal { get; set; }
        [Required]
        public decimal TaxAmt { get; set; }
        [Required]
        public decimal Freight { get; set; }
        [Required]
        public decimal TotalDue { get; set; }
        public string Comment { get; set; }
        [Required]
        public System.Guid rowguid { get; set; }
        [Required]
        public System.DateTime ModifiedDate { get; set; }
    
        public virtual Address BillToAddress { get; set; }
        public virtual Address ShipToAddress { get; set; }
        public virtual Customer Customer { get; set; }
        public virtual ICollection<SalesOrderDetail> SalesOrderDetails { get; set; }
    }
}
