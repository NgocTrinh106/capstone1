namespace MVCLOGIN.DbEF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SystemConfig")]
    public partial class SystemConfig
    {
        [StringLength(55)]
        public string SystemConfigID { get; set; }

        [StringLength(55)]
        public string SystemConfigName { get; set; }

        [StringLength(55)]
        public string SystemConfigType { get; set; }

        [StringLength(255)]
        public string SystemConfigValue { get; set; }

        public bool? SystemConfigStatus { get; set; }
    }
}
