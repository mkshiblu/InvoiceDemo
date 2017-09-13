using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace InvoiceDemo.Models
{
    public class Invoice
    {

        [DisplayName("Invoice Number")]
        public int ID { get; set; }
        public int ClientID { get; set; }

        [DisplayName("Date of Invoice")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime InvoiceDate { get; set; }

        [DisplayName("Due Date")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime DueDate { get; set; }

        [DisplayName("Sales Tax")]
        public double SalesTaxPercent { get; set; }

        [DisplayName("Payment Amount")]
        public double PaymentAmount { get; set; }
        // public double AmountDue { get; set; }
        public string Status { 
            get{
                if ((GrandTotal == PaymentAmount) && (AmountDue == 0))
                {
                return "Successful";
            }
       
        return "Pending";
        }
           protected set{} 
        
        }

        // The client of ClientID is automatically stroed in the client
        public virtual Client Client { get; set; }

        // Inovices items will be laaded autmatically in this
        public virtual IList<InvoiceItem> InvoiceItems { get; set; }


        #region Calculated Fields
        public double TotalSalesTax
        {
            get
            {
                return SubTotal * SalesTaxPercent / 100;
            }

            protected set { } // Declare an empty set so that it cannot be assigned but stored in db
        }

        [DisplayName("Sub Total")]
        public double SubTotal
        {
            get
            {
                return InvoiceItems == null ? 0 : InvoiceItems.Sum(item => item.Total);
            }
            protected set { } // Declare an empty set so that it cannot be assigned but stored in db
        }

        [DisplayName("Grand Total")]
        public double GrandTotal
        {
            get
            {
                return SubTotal + TotalSalesTax;
            }
            protected set { }   // Declare an empty set so that it cannot be assigned but stored in db
        }
        [DisplayName ("Amount Due")]
        public double AmountDue
        {
            get
            {
                
                return GrandTotal - PaymentAmount;
                
            }
            protected set { }
        }

        #endregion
    }
}