namespace shopqa.Controllers
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("shopqa.tbl_transaction")]
    public partial class tbl_transaction
    {
        [Key]
        public int pk_transaction_id { get; set; }

        public int c_status { get; set; }

        public int fk_customer_id { get; set; }

        [Column(TypeName = "date")]
        public DateTime c_date_create { get; set; }
    }
}
