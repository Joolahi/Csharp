using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T29_Cashier
{
    public interface ITransaction
    {
        // interface members
        string ShowTransaction();
        float Money { get; set; }
    }
    public class PaidWithCard : ITransaction
    {
        public static float  cardTotal = 0;
        public float cardAmount;
        public string cardNumber;
        public DateTime date;

        public PaidWithCard(float cardAmount, string cardNumber)
        {
            this.cardNumber = cardNumber;
            this.cardAmount= cardAmount;
            cardTotal += cardAmount;
            this.date = DateTime.Now;
        }
        public float Money
        { get { return cardAmount; }
            set {
                cardAmount= value;
            }
        }
        public string ShowTransaction()
        {
           return string.Format("Transaction to bank: charge from card {0} date {1} amount {2:C}", cardNumber, date, cardAmount);
        }
        public static float ShowTotal()
        {
            return cardTotal;
        }
    }
    class PaidWithCash : ITransaction
    {
        public static float cashTotal = 0;
        public DateTime date;
        public int bill;
        public float cashAmount;

        public PaidWithCash(int bill, float cashAmount)
        {
            this.bill = bill;
            this.cashAmount = cashAmount;
            this.date = DateTime.Now;
            cashTotal += cashAmount;
        }
       
        public string ShowTransaction()
        {
            return string.Format("Paid with cash: bill number {0} date {1} amount {2:C}", bill, date, cashAmount);
        }
        public float Money
        {
            get { return cashAmount; } set {cashAmount= value; }
        }

        public static float ShowCash()
        {
            return cashTotal;
        }
    }




    internal class Program
    {
        static void Main(string[] args)
        {
            PaidWithCard paymentWithCard1 = new PaidWithCard(78.95f,"0001-00002" );
            PaidWithCard paymentWithCard2 = new PaidWithCard(45.65f, "0003-0004");

            Console.WriteLine(paymentWithCard1.ShowTransaction());
            Console.WriteLine(paymentWithCard2.ShowTransaction());
            Console.WriteLine("Total money at bank account: {0:C}", PaidWithCard.ShowTotal());

            PaidWithCash cashPayment1 = new PaidWithCash(1, 100f);
            PaidWithCash cashPayment2 = new PaidWithCash(2, 50f);

            Console.WriteLine(cashPayment1.ShowTransaction());
            Console.WriteLine(cashPayment2.ShowTransaction());
            Console.WriteLine("Total money in cash: {0:C}", PaidWithCash.ShowCash());

            float totalSales = PaidWithCash.ShowCash() + PaidWithCard.ShowTotal();
            Console.WriteLine("Total sales today {0} is {1:C}?", DateTime.Now.ToString("dddd MMMM d, yyyy"), totalSales);

            Console.WriteLine("Program completed successfully. Press any key to quit.");
            Console.ReadKey();

        }
    }
}
