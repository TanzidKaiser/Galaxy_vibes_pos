﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace GalaxyVibesPos.Models
{
    [Table("Company")]
    public class Company
    {
        [Key]
        public int CompanyID { get; set; }
        public Nullable<int> GroupID { get; set; }
        public string CompanyName { get; set; }
        [ForeignKey("GroupID")]
        public virtual Group Group { get; set; }
        public virtual List<Sale> SaleList { get; set; }
        public virtual List<Customer> CustomerList { get; set; }
       
    }
}