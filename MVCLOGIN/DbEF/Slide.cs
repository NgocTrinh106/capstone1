namespace MVCLOGIN.DbEF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Slide")]
    public partial class Slide
    {
        public int SlideID { get; set; }

        [StringLength(255)]
        public string SlideImage { get; set; }

        public int? SlideDisplayOrder { get; set; }

        [StringLength(255)]
        public string SlideLink { get; set; }

        [StringLength(555)]
        public string SlideDescription { get; set; }

        public DateTimeOffset? SlideCreateDate { get; set; }

        [StringLength(50)]
        public string SlideCreatedBy { get; set; }

        public DateTimeOffset? SlideModifieDate { get; set; }

        [StringLength(50)]
        public string SlideModifiedBy { get; set; }

        public bool? SlideStatus { get; set; }
    }
}
