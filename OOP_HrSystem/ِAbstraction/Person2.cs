using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fundamentals_bakend.OOP_HrSystem._ِAbstraction
{
    internal class Person2
    {
        public String FirstName { get; private set; }
        public String LastName { get; private set; }
        public void SetName(String firstNmae, String lastNmae)
        {
            if (String.IsNullOrWhiteSpace(firstNmae) || String.IsNullOrWhiteSpace(lastNmae))
                throw new ArgumentNullException("Invalid Name");
            FirstName = firstNmae;
            LastName = lastNmae;
        }
        public DateOnly BirthDate { get; private set; }
        public void SetBirthDate(DateOnly birthDate)
        {
            if (birthDate <= new DateOnly(2003, 3, 1))
                throw new ArgumentNullException("Invalid birth date");
            BirthDate = birthDate;
        }
    }
}
