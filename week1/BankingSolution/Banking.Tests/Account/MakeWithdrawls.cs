using Banking.Domain;

namespace Banking.Tests.Account;
public class MakeWithdrawls
{
    [Fact]
    public void MakeWithdrawlDecreaseOurBalance()
    {
        var account = new BankAccount();
        var openingBalance = account.GetBalance();
        var amountToWithdrawl = 112.25M;

        account.Withdraw(amountToWithdrawl);

        var endingBalance = account.GetBalance();

        Assert.Equal(openingBalance - amountToWithdrawl, endingBalance);
    }
}
