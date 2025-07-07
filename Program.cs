using System;

class Program
{
    public static void Main()
    {
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
    }
}
