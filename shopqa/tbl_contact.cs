namespace shopqa.Controllers
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("shopqa.tbl_contact")]
    public partial class tbl_contact
    {
        [Key]
        public int pk_contact_id { get; set; }

        [Required]
        [StringLength(500)]
        public string c_address { get; set; }

        [Required]
        [StringLength(11)]
        public string c_phone { get; set; }

        [Required]
        [StringLength(200)]
        public string c_email { get; set; }

        [Required]
        [StringLength(500)]
        public string c_time_open { get; set; }
    }
}
