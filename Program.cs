using System;

public abstract class Payment
{
    public int Amount { get; set; }
    public string TransactionId { get; set; }

    public abstract void ProcessPayment();

    public abstract void ValidatePayment();

    public void ShowInfo()
    {
        Console.WriteLine("Amount: {0}", Amount);
        Console.WriteLine("TransactionId: {0}", TransactionId);
    }
}

// Inherit Payment
public class CreditCardPayment : Payment
{
    public string CardNumber { get; set; }

    public override void ProcessPayment()
    {
        Console.WriteLine("Processing Credit Card Payment...");
    }

    public override void ValidatePayment()
    {
        Console.WriteLine("Validating Credit Card Payment...");
    }
}

// Add BakashPayment class
public class BakashPayment : Payment
{
    public string BakashAccountNumber { get; set; }

    public override void ProcessPayment()
    {
        Console.WriteLine("Processing Bakash Payment...");
    }

    public override void ValidatePayment()
    {
        Console.WriteLine("Validating Bakash Payment...");
    }
}

class Program
{
    public static void Main()
    {
        Payment payment = new CreditCardPayment
        {
            Amount = 100,
            TransactionId = "12345",
            CardNumber = "928377"
        };

        payment.ValidatePayment();
        payment.ProcessPayment();

        // Example usage of BakashPayment
        Payment bakashPayment = new BakashPayment
        {
            Amount = 200,
            TransactionId = "67890",
            BakashAccountNumber = "017XXXXXXXX"
        };

        bakashPayment.ValidatePayment();
        bakashPayment.ProcessPayment();

        Console.WriteLine("Hello Class 3!");
    }
}
