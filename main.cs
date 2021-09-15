/*Author Charles Yingling     Date 9/14/2021
2. Write a program in C# to calculate commission based on the SalesAmount.


Based on the sales amount, display Performance Status
a) $0–2999 - Poor
c) $3000–4999 - Average
d) $5000–9999 - Good
e) $10000–14999 - Excellent
f) $15000 and above – Outstanding
Note: Sales Amount and Commission can be decimal values ex.356.89

*/
using System;

class Program {
  public static void Main (string[] args) {
    //ask for the Salesperson’s name and Sales Amount
    Console.WriteLine ("Enter Salesperson’s name");
    string name = Console.ReadLine();
    Console.WriteLine ("Enter Sales Amount");
    double sales = Convert.ToDouble(Console.ReadLine());

    //calculate the Commission: SALES COMMISSION = 200 + (0.09 * SALESAMOUNT)
    double comm = 200 + (0.09 * sales);
   Console.WriteLine ($"Sales commission for {name} is ${comm}");

   //$0–2999 - Poor
   if (comm <= 2999) {
   Console.WriteLine ("Performance is Poor");
   //$3000–4999 - Average
   } else if (comm > 3000 && comm < 4999) {
   Console.WriteLine ("Performance is Average");
   //$5000–9999 - Good
   } else if (comm > 5000 && comm < 9999) {
   Console.WriteLine ("Performance is Good");
   //$10000–14999 - Excellent
   } else if (comm > 10000 && comm < 14999) {
   Console.WriteLine ("Performance is Excellent");
   //$15000 and above – Outstanding
   } else if (comm > 15000) {
   Console.WriteLine ("Performance is Outstanding");
   }
    
  }
}