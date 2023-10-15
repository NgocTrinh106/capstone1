namespace MVCLOGIN.DbEF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ProductCategory")]
    public partial class ProductCategory
    {
        public long ProductCategoryID { get; set; }

        [StringLength(255)]
        public string ProductCategoryName { get; set; }

        [StringLength(255)]
        public string ProductCategoryMetaTitle { get; set; }

        public long? ProductCategoryParentID { get; set; }

        public int? ProductCategoryDisplayOrder { get; set; }

        [StringLength(255)]
        public string ProductCategorySeoTitle { get; set; }

        public DateTimeOffset? ProductCategoryCreateDate { get; set; }

        [StringLength(50)]
        public string ProductCategoryCreatedBy { get; set; }

        public DateTimeOffset? ProductCategoryModifieDate { get; set; }

        [StringLength(50)]
        public string ProductCategoryModifiedBy { get; set; }

        [StringLength(255)]
        public string ProductCategoryMetaKeywords { get; set; }

        [StringLength(555)]
        public string ProductCategoryMetaDescriptions { get; set; }

        public bool? ProductCategoryStatus { get; set; }

        public bool? ProductCategoryShowOnHome { get; set; }
    }
}
