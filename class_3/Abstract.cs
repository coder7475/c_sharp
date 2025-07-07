public abstract class Notification
{
    public string Recipient { get; set; }
    public string Message { get; set; }

    public abstract void Send();
    public abstract void Validate();
}

public class EmailNotification : Notification
{
    public string EmailAddress { get; set; }

    public override void Send()
    {
        Console.WriteLine($"Sending Email to {EmailAddress}: {Message}");
    }

    public override void Validate()
    {
        Console.WriteLine($"Validating Email Address: {EmailAddress}");
    }
}

public class SmsNotification : Notification
{
    public string PhoneNumber { get; set; }

    public override void Send()
    {
        Console.WriteLine($"Sending SMS to {PhoneNumber}: {Message}");
    }

    public override void Validate()
    {
        Console.WriteLine($"Validating Phone Number: {PhoneNumber}");
    }
}

// Link to Main (example usage)
// Place this code inside Main() in Program.cs to demonstrate usage:

/*
Notification email = new EmailNotification
{
    Recipient = "John Doe",
    Message = "Your order has been shipped.",
    EmailAddress = "john@example.com"
};

email.Validate();
email.Send();

Notification sms = new SmsNotification
{
    Recipient = "Jane Smith",
    Message = "Your OTP is 123456.",
    PhoneNumber = "0123456789"
};

sms.Validate();
sms.Send();
*/

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

