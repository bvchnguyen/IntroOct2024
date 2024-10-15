namespace CSharpSyntax;
public class BasicDataTypes
{
    [Fact]
    public void DeterminingTypes()
    {
        int y;
        int x = 12;
        decimal myPay = 12.83M;
        string myName = "Joe";

        // Var is only local
        var myName2 = 38;

        y = 32;
        // Char type
        var y = 'X';
    }

    [Fact]
    public void DeterminingTypes2()
    {
        // value type (struct) -- Lives on the stack
        var value = 'Y';

        // Reference type (Class) -- Lives on the heap
        var reference = "Bob";
    }

    [Fact]
    public void StringThingy()
    {
        string number = "";

        foreach (var n in Enumerable.Range(1, 10_000))
        {
            number += n;
        }

        // Every iteration, the heap will create a new instance
        // of that particular object at that iteration.
        // First iteration ""
        // Second iteration "1"
        // Third iteration "2"

        // All of these is it's own object. Meaning it's not getting concat
        // They're being created. 
    }
}
