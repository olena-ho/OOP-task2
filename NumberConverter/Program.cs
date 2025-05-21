using NumberConverter;

var originalNumber = new DecimalNumber(67);

Console.WriteLine($"{originalNumber.DecimalValue} is {originalNumber.ToBinary()} in hex");

originalNumber.PrintAll();