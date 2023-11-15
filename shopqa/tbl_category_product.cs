namespace shopqa.Controllers
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("shopqa.tbl_category_product")]
    public partial class tbl_category_product
    {
        [Key]
        public int pk_category_product_id { get; set; }

        [Required]
        [StringLength(500)]
        public string c_name { get; set; }

        public int c_parent_id { get; set; }
    }
}
