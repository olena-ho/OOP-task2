namespace MoneyManagement;

public class Product
{
    public string Name { get; set; }
    public Money Price { get; private set; }

    public Product(string name, Money price)
    {
        //this is where I make sure the price doesn't take negative value from Money
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

