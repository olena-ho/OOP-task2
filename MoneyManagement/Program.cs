using MoneyManagement;

//in case we want to type the currency in Ukranian
Console.OutputEncoding = System.Text.Encoding.UTF8;

try
{
    var money = new Money(50, 500, "USD");
    //  var money = new Money(-20, 50, "USD");
    //  var money = new Money(20, 500, "USD");
    var dress = new Product("Dress", money);
    dress.Print();

    dress.ReducePrice(30.00);
    dress.Print();
}
catch (InvalidOperationException ex)
{
    Console.WriteLine($"Error: {ex.Message}");
}
