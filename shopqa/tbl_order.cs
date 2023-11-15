namespace shopqa.Controllers
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("shopqa.tbl_order")]
    public partial class tbl_order
    {
        [Key]
        public int pk_order_id { get; set; }

        public int fk_transaction_id { get; set; }

        public float c_price { get; set; }

        public int c_number { get; set; }

        [Column(TypeName = "date")]
        public DateTime c_date_create { get; set; }

        public int c_status { get; set; }

        public int fk_product_id { get; set; }
    }
}
