namespace MVCLOGIN.DbEF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Footer")]
    public partial class Footer
    {
        [StringLength(55)]
        public string FooterID { get; set; }

        [Column(TypeName = "ntext")]
        public string FooterContent { get; set; }

        public bool? FooterStatus { get; set; }
    }
}
