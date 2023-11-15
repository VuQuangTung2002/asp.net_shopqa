namespace shopqa.Controllers
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("shopqa.tbl_comment")]
    public partial class tbl_comment
    {
        [Key]
        public int pk_comment_id { get; set; }

        public int fk_product_id { get; set; }

        public int fk_customer_id { get; set; }

        [Required]
        [StringLength(500)]
        public string c_date_create { get; set; }

        [Required]
        public string c_content { get; set; }

        [Required]
        [StringLength(500)]
        public string c_name { get; set; }
    }
}
