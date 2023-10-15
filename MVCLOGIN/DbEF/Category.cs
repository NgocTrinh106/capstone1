namespace MVCLOGIN.DbEF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Category")]
    public partial class Category
    {
        public long CategoryID { get; set; }

        [StringLength(255)]
        public string CategoryName { get; set; }

        [StringLength(255)]
        public string CategoryMetaTitle { get; set; }

        public long? CategoryParentID { get; set; }

        public int? CategoryDisplayOrder { get; set; }

        [StringLength(255)]
        public string CategorySeoTitle { get; set; }

        public DateTimeOffset? CategoryCreateDate { get; set; }

        [StringLength(50)]
        public string CategoryCreatedBy { get; set; }

        public DateTimeOffset? CategoryModifieDate { get; set; }

        [StringLength(50)]
        public string CategoryModifiedBy { get; set; }

        [StringLength(255)]
        public string CategoryMetaKeywords { get; set; }

        [StringLength(555)]
        public string CategoryMetaDescriptions { get; set; }

        public bool? CategoryStatus { get; set; }

        public bool? CategoryShowOnHome { get; set; }
    }
}
