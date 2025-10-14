using csharp.training.congruent.classes; 
namespace csharp.training.congruent.apps.OPrinciple
{
    internal class OPrinciple
    {   
	     static void Main(string[] _)
        {
            Console.WriteLine("Invoice Amount: 10000");
            Invoice FInvoice = new FinalInvoice();
            double FInvoiceAmount = FInvoice.GetInvoiceDiscount(10000);
            Console.WriteLine($"Final Invoice : {FInvoiceAmount}");
            Invoice PInvoice = new ProposedInvoice();
            double PInvoiceAmount = PInvoice.GetInvoiceDiscount(10000);
            Console.WriteLine($"Proposed Invoice : {PInvoiceAmount}");
            Invoice RInvoice = new RecurringInvoice();
            double RInvoiceAmount = RInvoice.GetInvoiceDiscount(10000);
            Console.WriteLine($"Recurring Invoice : {RInvoiceAmount}");
		}
    }
}
