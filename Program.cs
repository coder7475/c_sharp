using System;

public abstract class Payment {
  public int Amount { get; set;}
  public string TransactionId { get; set; }

  public abstract void ProcessPayment();

  public abstract void ValidatePayment();

  public void ShowInfo() {
    Console.WriteLine("Amount: {0}", Amount);
    Console.WriteLine("TransactionId: {0}", TransactionId);
  }
}

// Inhereit Payment
public class CreditCardPayment: Payment {
  public string CardNumber { get; set; }

    public override void ProcessPayment() {
      Console.WriteLine("Processing Credit Card Payment...");
    }

    public override void ValidatePayment() {
      Console.WriteLine("Validating Credit Card Payment...");
    }
}

class Program {
  public static void Main() {   
    Console.WriteLine("Hello Class 3!");
  }
}
