using Strategy_Pattern_Creating_an_invoice.Business.Models;
using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace Strategy_Pattern_Creating_an_invoice.Business.Strategies.Invoice
{
    public abstract class InvoiceStrategy : IInoviceStrategy
    {
        public abstract void Generate(Order order);

        public string GenrateTextInvoice(Order order)
        {
            var invoice = $"INVOICE DATE: {DateTimeOffset.Now}{Environment.NewLine}";
            invoice += $"ID|NAME|PRICE|QUANTITY{Environment.NewLine}";

            foreach(var item in order.LineItems)
            {
                invoice += $"{item.Key.Id}|{item.Key.Name}|{item.Key.Price}|{item.Value}";
            }

            invoice += Environment.NewLine + Environment.NewLine;

            var tax = order.GetTax();
            var total = order.TotalPrice + tax;

            invoice += $"TAX TOTAL: {tax}{Environment.NewLine}";
            invoice += $"TOTAL: {total}{Environment.NewLine}";

            return invoice;
        }
    }
}
