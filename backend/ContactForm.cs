// backend/ContactForm.cs
using System;
using System.Net.Mail;

public class ContactForm
{
    public static void Main(string[] args)
    {
        string name = Request.Form["name"];
        string email = Request.Form["email"];
        string message = Request.Form["message"];

        MailMessage mail = new MailMessage();
        mail.From = new MailAddress(email);
        mail.To.Add("bleufabs@gmail.com");
        mail.Subject = "Portfolio Contact Form";
        mail.Body = $"From: {name}\nEmail: {email}\n\n{message}";

        SmtpClient client = new SmtpClient("smtp.yourserver.com");
        client.Send(mail);
    }
}
// Note: Ensure to replace "smtp.yourserver.com" with your actual SMTP server address.
// Also, make sure to handle exceptions and validate inputs in a production environment.