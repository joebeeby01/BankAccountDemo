using AccountOverview;

Account account = new Account(
"Baroness K Brady",
"55501234",
"07-08-06",
"Current Account",
4500000.35m);

static void ShowAccountDetails(Account acc)
{
    acc.DisplayAccountInfo();
    Console.WriteLine();
    Console.WriteLine("Account Summary:");
    Console.WriteLine(acc.GetAccountSummary());
    Console.WriteLine();
}

ShowAccountDetails(account);
account.TransactionType();

//static void CompletingDeposit(Account acc)
//{
//    Console.WriteLine("Making Deposit...");
//    Console.Write("Enter deposit amount: ");

//    string input = Console.ReadLine();
//    if (decimal.TryParse(input, out decimal amount))
//    {
//        acc.Deposit(amount);
//    }
//    else
//    {
//        Console.WriteLine("Invalid amount entered. Please enter a valid decimal number.");
//    }
//    Console.WriteLine();
//    Console.WriteLine("Updated Account Summary:");
//    Console.WriteLine(acc.GetAccountSummary());
//}

//CompletingDeposit(account);

//static void CompletingPayment(Account acc)
//{
//    Console.WriteLine("Making Payment...");
//    Console.WriteLine("Who would you like to pay?: ");
//    string input = Console.ReadLine();
//    Console.Write("Enter payment amount: ");
//    string paymentInput = Console.ReadLine();
//    Console.WriteLine();
//    Console.WriteLine("Updated Account Summary:");
//    Console.WriteLine(acc.GetAccountSummary());
//}
//CompletingPayment(account);


static void LoggingOut(Account acc)
{
    Console.WriteLine();
    acc.LogOut();
}
LoggingOut(account);

Console.WriteLine("**************");
Console.WriteLine("**************");
Console.WriteLine("**************");
Console.WriteLine("**************");
Console.WriteLine("**************");

Account AnotherAccount = new Account(
  
    "Mo Salah",
    "36556320",
    "07-08-06",
    "Savings Account",
    1250000.00m
    );

ShowAccountDetails(AnotherAccount);

AnotherAccount.TransactionType();

//LoggingOut(AnotherAccount);

Console.WriteLine("**************");
Console.WriteLine("**************");
Console.WriteLine("**************");
Console.WriteLine("**************");
Console.WriteLine("**************");


ISA BuzzLightyear = new ISA(
    "Buzz Lightyear",
    "10203040",
    "070436",
    "ISA",
    100m
    );
ShowAccountDetails(BuzzLightyear);
BuzzLightyear.TransactionType();

//CompletingISA_Deposit(BuzzLightyear);
//static void CompletingISA_Deposit(Account acc)
//{
//    Console.WriteLine("Making ISA Deposit...");
//    Console.Write("Enter deposit amount: ");
//    string input = Console.ReadLine();
//    if (decimal.TryParse(input, out decimal amount))
//    {
//        acc.Deposit(amount);
//    }
//    else
//    {
//        Console.WriteLine("Invalid amount entered. Please enter a valid decimal number.");
//    }
//    Console.WriteLine();
//    Console.WriteLine("Updated Account Summary:");
//    Console.WriteLine(acc.GetAccountSummary());
//}
//CompletingISA_Deposit(BuzzLightyear);

//static void displayISA_Info(ISA isaAcc)
//{
//    Console.WriteLine();
//    isaAcc.DisplayAccountInfo();
//}
//displayISA_Info(BuzzLightyear);

//BuzzLightyear.ResetannualDeposits();

//displayISA_Info(BuzzLightyear);
//CompletingISA_Deposit(BuzzLightyear);
//static void CompletingISA_AnotherDeposit(Account acc)
//{
//    Console.WriteLine("Making ISA Deposit...");
//    Console.Write("Enter deposit amount: ");
//    string input = Console.ReadLine();
//    if (decimal.TryParse(input, out decimal amount))
//    {
//        acc.Deposit(amount);
//    }
//    else
//    {
//        Console.WriteLine("Invalid amount entered. Please enter a valid decimal number.");
//    }
//    Console.WriteLine();
//    Console.WriteLine("Updated Account Summary:");
//    Console.WriteLine(acc.GetAccountSummary());
//}
//CompletingISA_AnotherDeposit(BuzzLightyear);

//static void LoggingOutISA(Account acc)
//{
//    Console.WriteLine();
//    acc.LogOut();
//}
//LoggingOutISA(BuzzLightyear);
Console.WriteLine("**************");
Console.WriteLine("**************");
Console.WriteLine("**************");
Console.WriteLine("**************");
Console.WriteLine("**************");

Account lastAccount = new Account(
    "Flash Gordon",
    "77777777",
    "070094",
    "Business Account",
    0m);
ShowAccountDetails(lastAccount);

lastAccount.TransactionType();

//CompletingDeposit(lastAccount);
//LoggingOut(lastAccount);