namespace MoneyManagement;

public class Product
{
    public string Name { get; set; }
    public Money Price { get; private set; }

    public Product(string name, Money price)
    {
        if (price.ToDouble() < 0)
            throw new InvalidOperationException("Product price cannot be negative.");

        Name = name;
        Price = price;
    }

    public void ReducePrice(double amount)
    {
        Price.Subtract(amount);

        if (Price.ToDouble() < 0)
            throw new InvalidOperationException("Product price cannot be reduced below zero.");
    }

    public void Print()
    {
        Console.WriteLine($"{Name}: {Price}");
    }
}

