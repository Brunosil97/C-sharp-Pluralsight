using Strategy_Pattern_Creating_an_invoice.Business.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Strategy_Pattern_Creating_an_invoice.Business.Strategies.Invoice
{
    public class EmailInoviceStrategy : InvoiceStrategy
    {
        public override void Generate(Order order)
        {
            var body = GenrateTextInvoice(order);
        }
    }
}
