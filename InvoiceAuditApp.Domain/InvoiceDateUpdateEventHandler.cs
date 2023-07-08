using InvoiceAuditApp.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InvoiceAuditApp.Domain
{
    public delegate void InvoiceDateUpdateEventHandler(Invoice invoice, InvoiceDateUpdateEventArgs e);

}
