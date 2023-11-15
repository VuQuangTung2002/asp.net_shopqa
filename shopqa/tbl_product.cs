namespace shopqa.Controllers
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("shopqa.tbl_product")]
    public partial class tbl_product
    {
        [Key]
        public int pk_product_id { get; set; }

        public int fk_category_product_id { get; set; }

        [Required]
        [StringLength(500)]
        public string c_masp { get; set; }

        [Required]
        [StringLength(500)]
        public string c_name { get; set; }

        [Required]
        [StringLength(2000)]
        public string c_description { get; set; }

        [Required]
        [StringLength(500)]
        public string c_color { get; set; }

        [Required]
        [StringLength(50)]
        public string c_chatlieu { get; set; }

        [Required]
        public string c_noidung { get; set; }

        [Required]
        [StringLength(500)]
        public string c_nguongoc { get; set; }

        [Required]
        [StringLength(500)]
        public string c_img { get; set; }

        public float c_price { get; set; }

        [Column(TypeName = "date")]
        public DateTime c_date_created { get; set; }

        [Required]
        [StringLength(15)]
        public string c_sex { get; set; }

        public int c_sanphamnoibat { get; set; }

        public int total { get; set; }
    }
}
