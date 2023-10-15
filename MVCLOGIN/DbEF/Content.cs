namespace MVCLOGIN.DbEF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Content")]
    public partial class Content
    {
        public long ContentID { get; set; }

        [StringLength(50)]
        public string ContentName { get; set; }

        [StringLength(255)]
        public string ContentImage { get; set; }

        [StringLength(255)]
        public string ContentMetaTitle { get; set; }

        [StringLength(555)]
        public string ContentDescription { get; set; }

        [Column(TypeName = "ntext")]
        public string ContentDetail { get; set; }

        public int? ContentWarranty { get; set; }

        public DateTimeOffset? CreateDate { get; set; }

        [StringLength(50)]
        public string CreatedBy { get; set; }

        public DateTimeOffset? ModifieDate { get; set; }

        [StringLength(50)]
        public string ModifiedBy { get; set; }

        [StringLength(255)]
        public string MetaKeywords { get; set; }

        [StringLength(255)]
        public string MetaDescriptions { get; set; }

        public bool? Status { get; set; }

        public DateTime? Tophot { get; set; }

        public int? ViewCount { get; set; }

        public long? ProductCategoryID { get; set; }
    }
}
