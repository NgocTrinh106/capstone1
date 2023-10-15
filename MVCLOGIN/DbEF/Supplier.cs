namespace MVCLOGIN.DbEF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Supplier")]
    public partial class Supplier
    {
        public long SupplierID { get; set; }

        [StringLength(50)]
        public string SupplierName { get; set; }

        [StringLength(50)]
        public string Address { get; set; }

        [StringLength(20)]
        public string City { get; set; }

        [StringLength(10)]
        public string Phone { get; set; }

        [StringLength(20)]
        public string Region { get; set; }
    }
}
