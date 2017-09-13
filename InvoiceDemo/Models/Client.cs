using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace InvoiceDemo.Models
{
    public class Client
    {
        public int ID { get; set; }
        [DisplayName("Client Name")]
        public string Name { get; set; }
        public string Address { get; set; }
        public virtual IList<Invoice> Invoices { get; set; }
    }
}