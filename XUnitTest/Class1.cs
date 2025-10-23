using Xunit;
using AccountOverview;

public class AccountTests
{
    [Fact]
    public void Deposit_NegativeAmount_ShouldNotChangeBalance()
    {
        // Arrange
        var account = new Account(
            accountHolderName: "Test User",
            accountNumber: "12345678",
            sortCode: "12-34-56",
            accountType: "Test Account",
            balance: 1000.00m);
        decimal initialBalance = account.Balance;
        // Act
        account.Deposit(-500.00m);
        // Assert
        Assert.Equal(initialBalance, account.Balance);
    }

    [Fact]
    public void GetAccountSummary_ShouldReturnCorrectFormat()
    {
        // Arrange
        var account = new Account(
            accountHolderName: "Test User",
            accountNumber: "12345678",
            sortCode: "12-34-56",
            accountType: "Savings Account",
            balance: 1500.50m);
        // Act
        string summary = account.GetAccountSummary();
        // Assert
        Assert.Equal("Test User - Savings Account - Balance: £1,500.50", summary);
    }
    [Fact]
    public void MakePayment_InsufficientFunds_ShouldNotChangeBalance()
    {
        // Arrange
        var account = new Account(
            accountHolderName: "Test User",
            accountNumber: "12345678",
            sortCode: "12-34-56",
            accountType: "Test Account",
            balance: 300.00m);
        decimal initialBalance = account.Balance;
        // Act
        account.MakePayment(500.00m, "Joe");
        // Assert
        Assert.Equal(initialBalance, account.Balance);
    }
    [Fact]
    public void Deposit_ValidAmount_ShouldIncreaseBalance()
    {
        // Arrange
        var account = new Account(
            accountHolderName: "Test User",
            accountNumber: "12345678",
            sortCode: "12-34-56",
            accountType: "Test Account",
            balance: 1000.00m);
        decimal depositAmount = 500.00m;
        decimal expectedBalance = account.Balance + depositAmount;
        // Act
        account.Deposit(depositAmount);
        // Assert
        Assert.Equal(expectedBalance, account.Balance);
    }



}