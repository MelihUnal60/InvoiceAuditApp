using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InvoiceAuditApp.Domain
{
    
        public delegate void InvoiceAmountUpdateEventHandler(Invoice invoice, InvoiceAmountUpdateEventArgs e);
    
}
