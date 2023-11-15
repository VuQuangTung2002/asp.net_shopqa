namespace shopqa.Controllers
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("shopqa.tbl_user")]
    public partial class tbl_user
    {
        [Key]
        public int pk_user_id { get; set; }

        [Required]
        [StringLength(250)]
        public string c_username { get; set; }

        [Required]
        [StringLength(250)]
        public string c_fullname { get; set; }

        [Required]
        [StringLength(500)]
        public string c_img { get; set; }

        [Required]
        [StringLength(500)]
        public string c_password { get; set; }

        [Required]
        [StringLength(12)]
        public string c_phone { get; set; }

        [Required]
        [StringLength(250)]
        public string c_email { get; set; }

        [Required]
        [StringLength(500)]
        public string c_address { get; set; }

        [Required]
        [StringLength(10)]
        public string c_sex { get; set; }

        [Column(TypeName = "date")]
        public DateTime c_date_created { get; set; }

        [Column(TypeName = "date")]
        public DateTime c_birthday { get; set; }
    }
}
