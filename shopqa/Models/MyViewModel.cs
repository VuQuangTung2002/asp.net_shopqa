using shopqa.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace shopqa.Models
{
    public class MyViewModel
    {
        public List<tbl_album_product> album_product { get; set; }
        public List<tbl_category_product> Category_Products { get; set; }
        public List<tbl_comment> tbl_Comments { get; set; }
        public List<tbl_contact> tbl_contact { get; set;}

        public List<tbl_customer> tbl_customer { get; set; }
        public List<tbl_feedback> tbl_feedback { get; set; }
        public List<tbl_product> tbl_product { get; set; }
        public List<tbl_order> tbl_order { get; set; }
        public List<tbl_transaction> tbl_transaction { get; set; }
        public List<tbl_user> tbl_user { get; set; }
    }
}