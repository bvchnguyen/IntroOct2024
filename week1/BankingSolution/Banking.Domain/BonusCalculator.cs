
namespace Banking.Domain;

public class BonusCalculator
{
    public BonusCalculator()
    {
    }

    public decimal CalculateBonusForDeposit(decimal balance, decimal amount)
    {
        return balance >= 5000 ? amount * .10M : 0;
    }
}

public interface IBonusCalculator
{
    public decimal CalculateBonusForDeposit(decimal balance, decimal amount);
}