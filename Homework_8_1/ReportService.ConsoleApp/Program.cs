using Cipher;
using EmailSender;
using ReportService.Core;
using ReportService.Core.Domains;
using System;
using System.Collections.Generic;

namespace ReportService.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {

            var stringCipher = new StringCipher("");
            var encryptedPassword = stringCipher.Encrypt("Password");
            var decryptedPassword = stringCipher.Decrypt(encryptedPassword);

            Console.WriteLine(encryptedPassword);
            Console.WriteLine(decryptedPassword);

            return;

            var emailReceiver = "";
            var htmlEmail = new GenerateHtmlEmail();

            var email = new Email(new EmailParams
            {
                HostSmtp = "",
                Port = 111,
                EnableSsl = true,
                SenderName = "",
                SenderEmail = "",
                SenderEmailPassword = "",
            });

            var report = new Report()
            {
                Id = 1,
                Title = "",
                Date = new DateTime(2022, 1, 1, 12, 0, 0),
                Positions = new List<ReportPosition>()
                {
                    new ReportPosition()
                    {
                        Id = 1,
                        ReportId = 1,
                        Title = "Position 1",
                        Description = "Description 1",
                        Value = 43.01M
                    },
                    new ReportPosition()
                    {
                        Id = 2,
                        ReportId = 1,
                        Title = "Position 2",
                        Description = "Description 2",
                        Value = 143.01M
                    },
                    new ReportPosition()
                    {
                        Id = 3,
                        ReportId = 1,
                        Title = "Position 3",
                        Description = "Description 4",
                        Value = 454.01M
                    }

                }
            };

            var errors = new List<Error>()
            {
                new Error() {Message = "Błąd testowy 1", Date = DateTime.Now},
                new Error() {Message = "Błąd testowy 2", Date = DateTime.Now},
            };

            Console.WriteLine("Wysyłanie e-mail (Raport dobowy) ...");
            email.Send("Raport dobowy", htmlEmail.GenerateReport(report), emailReceiver).Wait();
            Console.WriteLine("Wysyłano e-mail (Raport dobowy) ...");

            Console.WriteLine("Wysyłanie e-mail (Błędy w aplikacji) ...");
            email.Send("Błędy w aplikacji", htmlEmail.GenerateErrors(errors, 10), emailReceiver).Wait();
            Console.WriteLine("Wysyłano e-mail (Błędy w aplikacji) ...");
        }
    }
}
