namespace shopqa.Controllers
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("shopqa.tbl_feedback")]
    public partial class tbl_feedback
    {
        [Key]
        public int pk_feedback_id { get; set; }

        [Required]
        [StringLength(500)]
        public string c_fullname { get; set; }

        [Required]
        [StringLength(100)]
        public string c_email { get; set; }

        [Required]
        [StringLength(12)]
        public string c_phone { get; set; }

        [Required]
        public string c_message { get; set; }

        [Column(TypeName = "date")]
        public DateTime c_date_create { get; set; }
    }
}
