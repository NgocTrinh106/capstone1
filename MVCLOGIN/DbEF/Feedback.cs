namespace MVCLOGIN.DbEF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Feedback")]
    public partial class Feedback
    {
        public int FeedbackID { get; set; }

        [StringLength(55)]
        public string FeedbackName { get; set; }

        [StringLength(55)]
        public string FeedbackPhone { get; set; }

        [StringLength(55)]
        public string FeedbackEmail { get; set; }

        [StringLength(55)]
        public string FeedbackAddress { get; set; }

        [StringLength(255)]
        public string FeedbackContent { get; set; }

        public DateTimeOffset? FeedbackCreateDate { get; set; }

        public bool? FeedbackStatus { get; set; }
    }
}
