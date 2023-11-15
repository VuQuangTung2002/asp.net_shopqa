using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace shopqa.Controllers
{
    public partial class shopqa : DbContext
    {
        public shopqa()
            : base("name=shopqa")
        {
        }

        public virtual DbSet<tbl_album_product> tbl_album_product { get; set; }
        public virtual DbSet<tbl_category_product> tbl_category_product { get; set; }
        public virtual DbSet<tbl_comment> tbl_comment { get; set; }
        public virtual DbSet<tbl_contact> tbl_contact { get; set; }
        public virtual DbSet<tbl_customer> tbl_customer { get; set; }
        public virtual DbSet<tbl_feedback> tbl_feedback { get; set; }
        public virtual DbSet<tbl_order> tbl_order { get; set; }
        public virtual DbSet<tbl_product> tbl_product { get; set; }
        public virtual DbSet<tbl_transaction> tbl_transaction { get; set; }
        public virtual DbSet<tbl_user> tbl_user { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}
