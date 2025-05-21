namespace NumberConverter;

internal struct DecimalNumber
{
    public int DecimalValue { get; }

    public DecimalNumber(int decimalValue)
    {
        DecimalValue = decimalValue;
    }

    public string ToBinary()
    {  
        return Convert.ToString(DecimalValue, 2); 
    }

    public string ToOctal()
    {
        return Convert.ToString(DecimalValue, 8);
    }

    public string ToHex()
    {
        return Convert.ToString(DecimalValue, 16);
    }

    public void PrintAll()
    {
        Console.WriteLine($"Decimal: {DecimalValue}");
        Console.WriteLine($"Binary: {ToBinary()}");
        Console.WriteLine($"Octal: {ToOctal()}");
        Console.WriteLine($"Hexadecimal: {ToHex()}");
    }
}
