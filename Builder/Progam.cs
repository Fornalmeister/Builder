using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    class Progam
    {
        static void Main(string[] args)
        {
            var builder = new InvoiceBuilder();
            
            Invoice invoice = builder.SetDate(DateTime.Now)
                .SetInvoiceNumber("Invoice-01")
                .SetVendor("Vendor")
                .SetVendee("Vendee")
                .SetLineItems(new List<string>() {"Line item1", "Line item2"})
                .Build();

            Console.WriteLine(invoice.Vendee);
        }
    }
}
