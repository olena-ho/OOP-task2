namespace MoneyManagement;

public class Money
{
    //I intentionally allow the number to be negative here, because the concept of money can have negative value (a debt, negative balance) in case we ever need the Money class for smth apart from price
    public int Major { get; set; }
    public int Minor { get; set; }
    public string Currency { get; set; }

    public Money(int major, int minor, string currency)
    {
        Currency = currency;
        SetNormalizedAmount(major, minor);
    }

    private void SetNormalizedAmount(int major, int minor)
    {
        Major = major + minor / 100;
        Minor = minor % 100;

        if (Minor < 0)
        {
            Major -= 1;
            Minor += 100;
        }
    }

    public double ToDouble()
    {
        return Major + Minor / 100.0;
    }

    public void Subtract(double amount)
    {
        double total = ToDouble() - amount;
        int majorPart = (int)total;
        int minorPart = (int)Math.Round((total - majorPart) * 100);

        SetNormalizedAmount(majorPart, minorPart);
    }

    public override string ToString()
    {
        return $"{Major}.{Math.Abs(Minor):00} {Currency}";
    }
}