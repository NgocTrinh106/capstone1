namespace MVCLOGIN.DbEF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("OrderT")]
    public partial class OrderT
    {
        [Key]
        public long OrderID { get; set; }

        [StringLength(20)]
        public string CustomerID { get; set; }

        [Column(TypeName = "date")]
        public DateTime? OrderDate { get; set; }

        [Column(TypeName = "date")]
        public DateTime? ShippedDate { get; set; }
    }
}
