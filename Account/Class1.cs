namespace AccountOverview
{
    public class Account
    {
        public string Institute = "nationwide";
        public string TagLine = "a good way to bank";
        public string AccountHolderName = "Mr A Sugar";
        public string AccountNumber = "33333334";
        public string SortCode = "070030";
        public string AccountType = "Savings";
        public decimal Balance = 5000.99m;


        public void DisplayAccountInfo()
        {
            Console.WriteLine($"Thank you for banking with {Institute}.");
            Console.WriteLine($"{Institute}, {TagLine}.");
            Console.WriteLine($"Account Holder: {AccountHolderName}");
            Console.WriteLine($"Sort Code: {SortCode}");
            Console.WriteLine($"Account Number: {AccountNumber}");
            Console.WriteLine($"Account Type: {AccountType}");
            Console.WriteLine($"Balance: {Balance:C}");
        }


        public string GetAccountSummary()
        {
            return $"{AccountHolderName} - {AccountType} Account - Balance: {Balance:C}";
        }

        public void Deposit(decimal amount)
        {
            if (amount <= 0)
            {
                Console.WriteLine("Deposit amount must be positive.");
                return;
            }
            Balance += amount;
            Console.WriteLine($"Deposited {amount:C}. New Balance: {Balance:C}");
        }

        public void MakePayment(decimal amount)
        {
            if (amount <= 0)
            {
                Console.WriteLine("Payment amount must be positive.");
                return;
            }
            if (amount > Balance)
            {
                Console.WriteLine("Insufficient funds for this payment.");
                return;
            }
            Balance -= amount;
            Console.WriteLine($"Payment of {amount:C} made. New Balance: {Balance:C}");
        }

        public void LogOut()
        {
            Console.WriteLine("You have been logged out.");
            Console.WriteLine($"Have a nice day, {AccountHolderName}!");
        }
    }
}
