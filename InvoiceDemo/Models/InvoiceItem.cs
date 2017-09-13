using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace InvoiceDemo.Models
{
    public class InvoiceItem
    {
        public int ID { get; set; }
        public int ProductID { get; set; }
        public int InvoiceID { get; set; }
        public int Quantity { get; set; }
        public bool Taxable { get; set; }
        public virtual Product Product { get; set; }
        public virtual Invoice Invoice { get; set; }

        #region calculated fields
        public double Total
        {
            get
            {
                return Product == null ? 0 : Quantity * this.Product.UnitPrice;
            }
            protected set { } // Declare an empty set so that it cannot be assigned but stored in db
        }
        #endregion
    }
}