using System.Security.Principal;


namespace AccountOverview
{
    public class Account
    {

        private string institute = "Nationwide";
        private string tagLine = "A good way to bank";
        private string accountHolderName = "Mr A Sugar";
        private string accountNumber = "33333334";
        private string sortCode = "07-00-30";
        private string accountType = "Savings";
        private decimal balance = 5000.99m;


        public string Institute
        {
            get => institute;
            private set => institute = value;
        }

        public string TagLine
        {
            get => tagLine;
            private set => tagLine = value;
        }

        public string AccountHolderName
        {
            get => accountHolderName;
            set
            {
                if (!string.IsNullOrWhiteSpace(value))
                    accountHolderName = value;
            }
        }

        public string AccountNumber
        {
            get => accountNumber;
            private set
            {
                if (AccountNumberFormatting(value).Length == 8)
                    accountNumber = value;
                else
                    Console.WriteLine(AccountNumberFormatting(value));
            }
        }

        public string SortCode
        {
            get => sortCode;
            private set
            {
                string formatted = FormatSortCode(value);
                if (formatted == null)
                {
                    Console.WriteLine($"{value} is not a valid sort code. It should contain exactly 6 digits.");
                    return;
                }
                sortCode = formatted;
            }
        }

        public string AccountType
        {
            get => accountType;
            set
            {
                string[] validTypes = { "Savings Account", "Current Account", "Business Account", "ISA", "Credit Card", "Personal Loan" };
                if (validTypes.Contains(value))
                    accountType = value;
                else
                    Console.WriteLine($"{value} is not a valid account type.");
            }
        }

        public decimal Balance
        {
            get => balance;
            private set => balance = value;
        }


        public Account(
            string accountHolderName = "Mr A Sugar",
            string accountNumber = "33333334",
            string sortCode = "07-00-30",
            string accountType = "Savings",
            decimal balance = 5000.99m)
        {
            AccountHolderName = accountHolderName;
            AccountNumber = accountNumber;
            SortCode = sortCode;
            AccountType = accountType;
            Balance = balance;
        }


        private string AccountNumberFormatting(string accountNumber)
        {
            if (accountNumber.Length < 8)
                return $"{accountNumber} is not valid, it should be 8 digits long.";
            else if (accountNumber.Length > 8)
                return $"{accountNumber} is not valid, it should be 8 digits long.";
            else
                return accountNumber;
        }

        private string FormatSortCode(string input)
        {
            // Remove all non-digit characters
            string digits = new string(input.Where(char.IsDigit).ToArray());

            if (digits.Length != 6)
                return null;

            // Return formatted like "xx-xx-xx"
            return $"{digits.Substring(0, 2)}-{digits.Substring(2, 2)}-{digits.Substring(4, 2)}";
        }

        // Methods
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
            return $"{AccountHolderName} - {AccountType} - Balance: {Balance:C}";
        }

        public virtual void Deposit(decimal amount)
        {
            if (amount <= 0)
            {
                Console.WriteLine("Deposit amount must be positive.");
                return;
            }
            Balance += amount;
            Console.WriteLine($"Deposited {amount:C}. New Balance: {Balance:C}");
        }


        public void MakePayment(decimal amount, string payee)
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
            Console.WriteLine($"Payment of {amount:C} made to {payee}. New Balance: {Balance:C}");
        }


        public void LogOut()
        {
            Console.WriteLine("You have been logged out."); Console.WriteLine($"Have a nice day, {AccountHolderName}!");
        }


        public void TransactionType()
        {
            while (true)
                if (AccountType != "ISA")
                {
                    {
                        Console.WriteLine("Which transaction would you like to complete?");
                        Console.WriteLine("1. Deposit");
                        Console.WriteLine("2. Make Payment");
                        Console.WriteLine("3. Account Summary");
                        Console.WriteLine("4. Log out");
                        Console.Write("Enter your choice: ");
                        string input = Console.ReadLine();

                        switch (input)
                        {
                            case "1":
                                Console.Write("Enter deposit amount: ");
                                if (decimal.TryParse(Console.ReadLine(), out decimal depositAmount))
                                {
                                    Deposit(depositAmount);
                                }
                                else
                                {
                                    Console.WriteLine("Invalid amount entered.");
                                }
                                break;

                            case "2":
                                Console.Write("Who would you like to pay?: ");
                                string payee = Console.ReadLine();
                                Console.Write("Enter payment amount: ");
                                if (decimal.TryParse(Console.ReadLine(), out decimal paymentAmount))
                                {

                                    MakePayment(paymentAmount, payee);
                                }
                                else
                                {
                                    Console.WriteLine("Invalid amount entered.");
                                }
                                break;

                            case "3":
                                Console.WriteLine(GetAccountSummary());
                                break;

                            case "4":
                                Console.WriteLine("Logging out...");
                                LogOut();
                                return;

                            default:
                                Console.WriteLine("Invalid selection, please choose a valid option.");
                                break;
                        }
                    }
                }
                else
                {
                    Console.WriteLine("Which transaction would you like to complete?");
                    Console.WriteLine("1. Deposit");
                    Console.WriteLine("2. Make Payment");
                    Console.WriteLine("3. Account Summary");
                    Console.WriteLine("4. Log out");
                    Console.WriteLine("5. Show Remaining ISA allowance");
                    Console.WriteLine("6. Reset ISA allowance(Tax year only)");
                    Console.Write("Enter your choice: ");
                    string input = Console.ReadLine();

                    switch (input)
                    {
                        case "1":
                            Console.Write("Enter deposit amount: ");
                            if (decimal.TryParse(Console.ReadLine(), out decimal depositAmount))
                            {
                                Deposit(depositAmount);
                            }
                            else
                            {
                                Console.WriteLine("Invalid amount entered.");
                            }
                            break;

                        case "2":
                            Console.Write("Who would you like to pay?: ");
                            string payee = Console.ReadLine();
                            Console.Write("Enter payment amount: ");
                            if (decimal.TryParse(Console.ReadLine(), out decimal paymentAmount))
                            {

                                MakePayment(paymentAmount, payee);
                            }
                            else
                            {
                                Console.WriteLine("Invalid amount entered.");
                            }
                            break;

                        case "3":
                            Console.WriteLine(GetAccountSummary());
                            break;

                        case "4":
                            Console.WriteLine("Logging out...");
                            LogOut();
                            return;
                        case "5":
                            Console.WriteLine("Option 5 is undergoing construction please default to another number");
                            //Console.WriteLine($"Annual Deposits this year: {annualDeposits:C} / {ISA_Limit:C}");
                            break;
                        case "6":
                            Console.WriteLine("Option 6 is undergoing construction please default to another number");
                            //ResetannualDeposits();
                            break;

                        default:
                            Console.WriteLine("Invalid selection, please choose a valid option.");
                            break;
                    } ;


            }
        }




        //public void TransactionType()
        //{
        //    Console.WriteLine("Which transaction would you like to complete?");
        //    Console.WriteLine("1. Deposit");
        //    Console.WriteLine("2. Make Payment");
        //    Console.WriteLine("3. Account Summary");
        //    Console.WriteLine("4. Log out");
        //    string input = Console.ReadLine();
        //    if (input == "1")
        //    {
        //        Deposit();
        //    }
        //    else if (input == "2")
        //    {
        //        MakePayment();
        //    }
        //    else if (input == "3")
        //    {
        //        GetAccountSummary();
        //    }
        //    else if (input == "4")
        //    {
        //        LogOut();
        //    }
        //    else
        //    {
        //        Console.WriteLine("Invalid selection, please choose a valid option.");
        //        TransactionType();





    }        
                
            }

        



//if (input.Equals("Y", StringComparison.OrdinalIgnoreCase))
//{
//    Console.WriteLine($"You have been logged out, have a nice day {accountHolderName}");
//}
//else if (input.Equals("N", StringComparison.OrdinalIgnoreCase))
//{
//    Console.WriteLine("You remain logged in.");
//}

//{