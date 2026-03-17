using KK.DesignPattern.Decorator;
using KK.DesignPattern.Decorator.Decorators;

public static class Program
{
    public static void Main()
    {
        Console.WriteLine();
        var notify = new Notifier();
        notify.Notify("Message");

        Console.WriteLine();
        var smsNotify = new SmsNotifier(notify);
        smsNotify.Notify("Notify wrapped with sms");

        Console.WriteLine();
        var emailNotify = new EmailNotifier(notify);
        emailNotify.Notify("Notify wrapped with email");

        Console.WriteLine();
        var smsAndEmailNotify = new EmailNotifier(smsNotify);
        smsAndEmailNotify.Notify("Notify wrapped with sms and email");

        Console.WriteLine();
        var emailAndSmsNotify = new SmsNotifier(emailNotify);
        emailAndSmsNotify.Notify("Notify wrapped with email and sms");
    }
}