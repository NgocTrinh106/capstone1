namespace MVCLOGIN.DbEF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Customer")]
    public partial class Customer
    {

        public long CustomerID { get; set; }

        [Required]
        [StringLength(50, ErrorMessage ="Không được quá 50 ký tự")]
        [Display(Name ="Họ")]
        public string CustomerFirstName { get; set; }

        [Required]
        [StringLength(50,ErrorMessage ="Không được quá 50 ký tự")]
        [Display(Name = "Tên")]

        public string CustomerLastName { get; set; }

        [Display(Name = "Giới tính")]

        public bool? CustomerSex { get; set; }

        [StringLength(255, ErrorMessage = "Không được quá 255 ký tự")]
        [Display(Name = "Metatitle")]
        public string MetaTitle { get; set; }
        [Display(Name = "ParentID")]

        public long? CustomerParentID { get; set; }
        [Display(Name = "Thứ tự hiển thị")]

        public int? DisplayOrder { get; set; }

        [StringLength(255, ErrorMessage = "Không được quá 255 ký tự")]
        [Display(Name = "Seotitle")]

        public string SeoTitle { get; set; }
        [Display(Name = "Ngày tạo")]

        public DateTimeOffset? CreateDate { get; set; }

        [StringLength(20, ErrorMessage = "Không được quá 20 ký tự")]
        [Display(Name = "Số Điện thoại")]

        public string Phone { get; set; }

        [Required]
        [StringLength(50, ErrorMessage = "Không được quá 50 ký tự")]
        [Display(Name = "Email")]

        public string Email { get; set; }

        [StringLength(255, ErrorMessage = "Không được quá 255 ký tự")]
        [Display(Name = "mật khẩu")]

        public string Password { get; set; }

        [StringLength(50, ErrorMessage = "Không được quá 50 ký tự")]
        [Display(Name = "Địa chỉ")]

        public string Address { get; set; }

        [StringLength(20, ErrorMessage = "Không được quá 20 ký tự")]
        [Display(Name = "Lời chào")]

        public string Salutation { get; set; }

        [StringLength(20, ErrorMessage = "Không được quá 20 ký tự")]
        [Display(Name = "Thành phố")]

        public string City { get; set; }

        [StringLength(20, ErrorMessage = "Không được quá 20 ký tự")]
        [Display(Name = "Quốc tịch")]

        public string Region { get; set; }
    }
}
