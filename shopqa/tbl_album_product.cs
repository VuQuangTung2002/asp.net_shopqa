namespace shopqa.Controllers
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("shopqa.tbl_album_product")]
    public partial class tbl_album_product
    {
        [Key]
        public int pk_album_product_id { get; set; }

        [Required]
        [StringLength(500)]
        public string fk_product_id { get; set; }

        [Required]
        [StringLength(500)]
        public string c_img { get; set; }

        public int status { get; set; }
    }
}
