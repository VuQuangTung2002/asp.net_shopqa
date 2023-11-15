namespace shopqa.Controllers
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("shopqa.tbl_customer")]
    public partial class tbl_customer
    {
        [Key]
        public int pk_customer_id { get; set; }

        [Required]
        [StringLength(500)]
        public string c_fullname { get; set; }

        [Required]
        [StringLength(500)]
        public string c_password { get; set; }

        [Required]
        [StringLength(500)]
        public string c_email { get; set; }

        [Column(TypeName = "date")]
        public DateTime c_date_create { get; set; }

        [Required]
        [StringLength(12)]
        public string c_phone { get; set; }
    }
}
