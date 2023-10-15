namespace MVCLOGIN.DbEF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("About")]
    public partial class About
    {
        public long AboutID { get; set; }

        [StringLength(50)]
        public string AboutName { get; set; }

        [StringLength(255)]
        public string AboutImage { get; set; }

        [StringLength(255)]
        public string AboutMetaTitle { get; set; }

        [StringLength(555)]
        public string AboutDescription { get; set; }

        [Column(TypeName = "ntext")]
        public string AboutDetail { get; set; }

        public DateTimeOffset? AboutCreateDate { get; set; }

        [StringLength(50)]
        public string AboutCreatedBy { get; set; }

        public DateTimeOffset? AboutModifieDate { get; set; }

        [StringLength(50)]
        public string AboutModifiedBy { get; set; }

        [StringLength(255)]
        public string AboutMetaKeywords { get; set; }

        [StringLength(255)]
        public string AboutMetaDescriptions { get; set; }

        public bool? AboutStatus { get; set; }
    }
}
