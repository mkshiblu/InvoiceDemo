using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace InvoiceDemo.Models
{
    public class Product
    {
        public int ID { get; set; }
        [DisplayName("Item")]
        public string Name { get; set; }
        public string Description { get; set; }
        [DisplayName("Price (each)")]
        public double UnitPrice { get; set; }
    }
}