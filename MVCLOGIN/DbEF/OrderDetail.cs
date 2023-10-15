namespace MVCLOGIN.DbEF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class OrderDetail
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long OrderDID { get; set; }

        public long? OrderID { get; set; }

        public long? ProductID { get; set; }

        public double? UnitPrice { get; set; }

        public int? Quantity { get; set; }

        public bool? Status { get; set; }
    }
}
