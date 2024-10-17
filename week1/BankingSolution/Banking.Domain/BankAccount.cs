


namespace Banking.Domain;

public class BankAccount
{
    private decimal _balance = 5000M;
    private IBonusCalculator _calculator;

    public BankAccount(IBonusCalculator bonusCalculator)
    {
        _calculator = bonusCalculator;
    }
    public virtual void Deposit(decimal amountToDeposit)
    {
        decimal bonus = _calculator.CalculateBonusForDeposit(_balance, amountToDeposit);

        _balance = amountToDeposit + bonus;
    }

    public decimal GetBalance()
    {
        return _balance;
    }

    public void Withdraw(decimal amountToWithdraw)
    {
        if (_balance > amountToWithdraw)
        {
            _balance -= amountToWithdraw;
        }
        else
        {
            throw new AccountOverdraftException();
        }
    }
}

public class AccountOverdraftException : ArgumentOutOfRangeException;