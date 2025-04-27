using System.Runtime.ConstrainedExecution;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Tasks
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Islam's Carpet Cleaning Service");
            Console.WriteLine("Charges :  \n\t $25 per small   \n\t $35 per large\n");
            Console.WriteLine("\nSales tax rate is 6 %  \nEstimates are valid for 30 days");

            Console.WriteLine("\nPlease Enter Number Of Small Carpets : ");
            int NumberOfSmallCarpets = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\nPlease Enter Number Of Large Carpets : ");
            int NumberOfLargeCarpets = Convert.ToInt32(Console.ReadLine());
            int PricePerSmallCarpet = Convert.ToInt32(NumberOfSmallCarpets * 25);
            int PricePerLargeCarpet = Convert.ToInt32(NumberOfLargeCarpets * 35);
            int Cost = Convert.ToInt32(PricePerSmallCarpet + PricePerLargeCarpet);
            double TotalAfterTax = Convert.ToDouble(Cost + 6.6);
            Console.WriteLine($"Number Of Small Carpets :{NumberOfSmallCarpets} ");
            Console.WriteLine($"Number Of Large Carpets :{NumberOfLargeCarpets} ");
            Console.WriteLine($"\n\nTotal Price Of Small Carpets Before Tax Is :${PricePerSmallCarpet} ");
            Console.WriteLine($"\n\nTotal Price Of Large Carpets Before Tax Is :${PricePerLargeCarpet} ");
            Console.WriteLine($"\n\nCost Before Tax : ${Cost}");
            Console.WriteLine("\n\nTax : $6.6");
            Console.WriteLine("\n===============================");
            Console.WriteLine($"\n\nTotal Estimate : ${TotalAfterTax}");
            Console.WriteLine("\nThis estimate is valid for 30 days\n");


        }
    }
}
