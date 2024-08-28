using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fundamentals_bakend.OOP_HrSystem._ِAbstraction
{
    internal class Notifier : INotifier
    {
        public Notifier(string smtpServer, int port, string senderAddress, string senderPassword) 
        {
            SmtpServer = smtpServer;
            Port = port;
            SenderAddress = senderAddress;
            SenderPassword = senderPassword;
        }

        public string SmtpServer { get; }
        public int Port { get; }
        public string SenderAddress { get; }
        public string SenderPassword { get; }
        public void Notify(string email, string subject, string body)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"You're a new email from '{SenderAddress}' with subiect '{subject}'");
            Console.WriteLine(body);
            Console.WriteLine($"Messase sent successfully to '{email}'");
            Console.WriteLine("---------------------------------------------------");
            Console.ForegroundColor = ConsoleColor.Green;
        }
    }
}
