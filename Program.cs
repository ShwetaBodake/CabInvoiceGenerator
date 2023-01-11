// See https://aka.ms/new-console-template for more information
namespace CabInvoiceGenerator
{

public class Program
    {
       
            public enum Month
        {
            Jan,Feb,March,April,May
        };
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the CabInvoice Generator");
            InvoiceGenerator invoiceGenerator = new InvoiceGenerator(RideType.NORMAL);
            double Fare = invoiceGenerator.CalculateFare(2.0 ,5);
            Console.WriteLine(Fare);
        }
    }
}
