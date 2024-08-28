using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fundamentals_bakend.OOP_HrSystem._ِAbstraction
{
    internal class PayslipGenerator 
    {
        private readonly INotifier _notifier;

        public PayslipGenerator(INotifier notifier)
        {
            this._notifier = notifier;
        }

       

        public Notifier Notifier { get; }

        public void Generate(Emplyee4 emplyee)
        {
            var payItems =  emplyee.GetPayItems();
            var message = new StringBuilder();
            message.AppendLine($"Deir {emplyee.FirstName} {emplyee.LastName}");
            message.AppendLine("Please find below your payslip detaits: ");
            foreach (var payItem in payItems)
            {
                message.AppendLine($"{payItem.Name}\t\t{payItem.Value}");
                _notifier.Notify(emplyee.Email, "Payslip Gem=nerated !", message.ToString());
            }
        }

       
    }
}
