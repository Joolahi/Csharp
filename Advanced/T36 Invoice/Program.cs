using System;
using System.Collections.Generic;

class InvoiceItem
{
    public string Name { get; set; }
    public double Price { get; set; }
    public int Quantity { get; set; }

    public double Total => Price * Quantity;

    public override string ToString()
    {
        return $"{Name} {Price + "e"} {Quantity} pieces {Total + "e"} total";
    }
}

class Invoice
{
    public string Customer { get; set; }
    public List<InvoiceItem> Items { get; set; }

    public int ItemsCount => Items.Count;
    public int ItemsTogether
    {
        get
        {
            int total = 0;
            foreach (var item in Items)
            {
                total += item.Quantity;
            }
            return total;
        }
    }

    public double CountTotal()
    {
        double total = 0;
        foreach (var item in Items)
        {
            total += item.Total;
        }
        return total;
    }

    private string PrintInvoice()
    {
        string invoiceString = $"Customer {Customer}'s invoice:\n";
        invoiceString += "=================================\n";
        foreach (var item in Items)
        {
            invoiceString += item.ToString() + "\n";
        }
        invoiceString += "=================================\n";
        invoiceString += $"Total: {ItemsTogether} pieces {CountTotal()} euros\n";
        return invoiceString;
    }

    public void DisplayInvoice()
    {
        Console.WriteLine(PrintInvoice());
    }
}

class Program
{
    static void Main(string[] args)
    {
        InvoiceItem item1 = new InvoiceItem { Name = "Tomato", Price = 0.90, Quantity = 6 };
        InvoiceItem item2 = new InvoiceItem { Name = "Salad", Price = 1.80, Quantity = 2 };
        InvoiceItem item3 = new InvoiceItem { Name = "Butter", Price = 2.50, Quantity = 2 };
        InvoiceItem item4 = new InvoiceItem { Name = "Juice", Price = 1.50, Quantity = 1 };


        Invoice invoice = new Invoice
        {
            Customer = "Joonas Lahti",
            Items = new List<InvoiceItem> { item1, item2, item3, item4 }
        };
        invoice.DisplayInvoice();
    }
}
