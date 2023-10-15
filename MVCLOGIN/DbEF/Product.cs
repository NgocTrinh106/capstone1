namespace MVCLOGIN.DbEF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Product")]
    public partial class Product
    {
        public long ProductID { get; set; }

        [StringLength(50)]
        public string ProductName { get; set; }

        [StringLength(50)]
        public string ProductCode { get; set; }

        public int? UnitInStock { get; set; }

        public int? UnitInOrder { get; set; }

        public int? QuantityPerUnit { get; set; }

        public decimal? Price { get; set; }

        public decimal? PromotionPrice { get; set; }

        public bool? IncludeVAT { get; set; }

        [StringLength(255)]
        public string ProductImage { get; set; }

        [Column(TypeName = "xml")]
        public string ProductMoreImage { get; set; }

        [StringLength(255)]
        public string ProductMetaTitle { get; set; }

        [StringLength(555)]
        public string ProductDescription { get; set; }

        [Column(TypeName = "ntext")]
        public string ProductDetail { get; set; }

        public int? ProductWarranty { get; set; }

        public DateTimeOffset? ProductCreateDate { get; set; }

        [StringLength(50)]
        public string ProductCreatedBy { get; set; }

        public DateTimeOffset? ProductModifieDate { get; set; }

        [StringLength(50)]
        public string ProductModifiedBy { get; set; }

        [StringLength(255)]
        public string ProductMetaKeywords { get; set; }

        [StringLength(255)]
        public string ProductMetaDescriptions { get; set; }

        public bool? ProductStatus { get; set; }

        public DateTime? Tophot { get; set; }

        public int? ProductViewCount { get; set; }

        [StringLength(555)]
        public string Tags { get; set; }

        public long? ProductCategoryID { get; set; }

        public long? SupplierID { get; set; }
    }
}
