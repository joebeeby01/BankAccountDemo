using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace AccountOverview
{
    public class ISA : Account
    {
        private const decimal ISA_Limit = 20000m;
        private decimal annualDeposits = 0m;
        public ISA(
            string accountHolderName = "Mr A Sugar",
            string accountNumber = "33333334",
            string sortCode = "07-00-30",
            string accountType = "ISA",
            decimal balance =0m)
            : base(
                accountHolderName,
                accountNumber,
                sortCode,
                accountType,
                balance
                )
        {
        }

        public override void Deposit(decimal amount)
        {
            if (amount <= 0)
            {
                Console.WriteLine("Deposit amount must be positive.");
                return;
            }
            if (annualDeposits + amount > ISA_Limit)
            {
                decimal remaining = ISA_Limit - annualDeposits;
                Console.WriteLine($"Deposit exceeds annual ISA limit of {ISA_Limit:C}. You can deposit up to {(ISA_Limit - annualDeposits)} more this year.");
                return;
            }
            annualDeposits += amount;
            base.Deposit(amount);
        }


            public void ResetannualDeposits()
            {
            annualDeposits = 0m;
            Console.WriteLine("Annual deposit limit resets 6th April, this has been reset");
            }

        public new void DisplayAccountInfo()
        {
            base.DisplayAccountInfo();
            Console.WriteLine($"Annual Deposits this year: {annualDeposits:C} / {ISA_Limit:C}");
        }

    }
}
