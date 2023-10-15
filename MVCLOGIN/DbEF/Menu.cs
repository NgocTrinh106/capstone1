namespace MVCLOGIN.DbEF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Menu")]
    public partial class Menu
    {
        public int MenuID { get; set; }

        [StringLength(55)]
        public string MenuText { get; set; }

        [StringLength(55)]
        public string Menulink { get; set; }

        public int? MenuDisplayOrder { get; set; }

        [StringLength(55)]
        public string MenuTarget { get; set; }

        public bool? MenuStatus { get; set; }

        public int? MenuTypeID { get; set; }
    }
}
