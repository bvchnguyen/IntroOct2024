using Banking.Domain;

namespace Banking.Tests.BonusCalculation;
public class DepositsOnNewAccounts
{

    [Fact]
    public void DepositsAboveThresholdGetBonus()
    {
        var bonusCalculator = new BonusCalculator();

        decimal bonus = bonusCalculator.CalculateBonusForDeposit(balance: 5000M, amount: 100);

        Assert.Equal(10M, bonus);
    }

    [Fact]
    public void DepositsBelowThresholdGetBonus()
    {
        var bonusCalculator = new BonusCalculator();

        decimal bonus = bonusCalculator.CalculateBonusForDeposit(balance: 4000M, amount: 100);

        Assert.Equal(0, bonus);
    }



}
