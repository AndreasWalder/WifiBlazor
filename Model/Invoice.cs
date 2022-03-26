using System;
using System.Linq;

namespace WifiBlazor.Model
{
    public class Invoice
    {
        public int Id { get; set; } 
        public int InvoiceNr { get; set; }  
        public string Service { get; set; }
        public DateTime DateOfService { get; set; }
        public Company Company { get; set; }
        public bool Paid { get; set; } = false; 

        public Invoice()
        {
            if (DB.ListOfInvoices.Count < 1)
            {
                Id = 1;
                InvoiceNr = 1001;
            }
            else
            {
                Id = DB.ListOfInvoices.LastOrDefault().Id + 1;
                InvoiceNr = DB.ListOfInvoices.LastOrDefault().InvoiceNr + 1;
            }
        }
    }
}
