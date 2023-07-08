using InvoiceAuditApp.Domain;

Invoice invoice = new Invoice();
invoice.DocDate = Convert.ToDateTime("02.11.2022");
invoice.DocAmount = 342;
invoice.SerialNumber = 11111;

invoice.InvoiceDateUpdated += Invoice_InvoiceDateUpdated;
invoice.DocDate = DateTime.Now;


invoice.InvoiceSerialNumberUpdated += Invoice_InvoiceSerialNumberUpdated;
invoice.SerialNumber = 12345;

invoice.InvoiceAmountUpdated += Invoice_InvoiceAmountUpdated;
invoice.DocAmount = 1345;

void Invoice_InvoiceAmountUpdated(Invoice invoice, InvoiceAmountUpdateEventArgs e)
{
    Console.WriteLine($"{e.SerialNumber} numaralı faturanın belge tutarı değişti : {e.NewAmount}");
}

void Invoice_InvoiceSerialNumberUpdated(Invoice invoice, InvoiceSerialNumberUpdateEventArgs e)
{
    Console.WriteLine($"{e.OldSerialNumber} numaralı faturanın yeni belge numarası : {e.NewSerialNumber}");
}

void Invoice_InvoiceDateUpdated(Invoice invoice, InvoiceDateUpdateEventArgs e)
{
    Console.WriteLine($"{e.SerialNumber} numaralı faturanın tarihi güncellendi : {e.NewDate}");
}