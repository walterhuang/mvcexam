namespace WebApplication1.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    
    [MetadataType(typeof(SalesOrderDetailMetaData))]
    public partial class SalesOrderDetail
    {
    }
    
    public partial class SalesOrderDetailMetaData
    {
        [Required]
        public int SalesOrderID { get; set; }
        [Required]
        public int SalesOrderDetailID { get; set; }
        [Required]
        public short OrderQty { get; set; }
        [Required]
        public int ProductID { get; set; }
        [Required]
        public decimal UnitPrice { get; set; }
        [Required]
        public decimal UnitPriceDiscount { get; set; }
        [Required]
        public decimal LineTotal { get; set; }
        [Required]
        public System.Guid rowguid { get; set; }
        [Required]
        public System.DateTime ModifiedDate { get; set; }
    
        public virtual Product Product { get; set; }
        public virtual SalesOrderHeader SalesOrderHeader { get; set; }
    }
}
