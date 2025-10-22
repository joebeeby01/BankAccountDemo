using AccountOverview;

Account account = new Account();
//account.Institute = "";
//account.TagLine = "";
account.AccountHolderName = "Baroness K Brady";
account.AccountNumber = "55501234";
account.SortCode = "07-08-06";
account.AccountType = "Current Account";
account.Balance = 4500000.35m;

static void ShowAccountDetails(Account acc)
{
    acc.DisplayAccountInfo();
    Console.WriteLine();
    Console.WriteLine("Account Summary:");
    Console.WriteLine(acc.GetAccountSummary());
    Console.WriteLine();
}

ShowAccountDetails(account);


static void CompletingDeposit(Account acc)
{
    Console.WriteLine("Making Deposit...");
    Console.WriteLine();
    acc.Deposit(60000.00m);
    Console.WriteLine();
    Console.WriteLine("Updated Account Summary:");
    Console.WriteLine(acc.GetAccountSummary());
}

CompletingDeposit(account);

static void CompletingPayment(Account acc)
{
    Console.WriteLine("Making Payment to West Ham Football Club");
    Console.WriteLine();
    acc.MakePayment(4250000.35m);
    Console.WriteLine();
    Console.WriteLine("Updated Account Summary:");
    Console.WriteLine(acc.GetAccountSummary());
}
CompletingPayment(account);


static void LoggingOut(Account acc)
{
    Console.WriteLine();
    acc.LogOut();
}
LoggingOut(account);