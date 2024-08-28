using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fundamentals_bakend.NewFolder
{
    internal class Student
    {
        
         // Q-38
         /*
        public Student()
        {
            Console.WriteLine("A name student has been instialized");
            this.Name = Name;
        }
        public String Name { get; set; }
        public int PhoneNumber { get; set; }
        public String Adress { get; set; }
        
        */
        // Q-39
        
        public Student(String name)
        {
            this.Name=name;
        }
        public String Name { get; init; } // (init) time inslaizetion
        
        /*
        private String _name;
        public String Name
        { 
            get
            {
                return _name;
            }
            set
            {
                _name = value;
            } }
        */

        // Q-41 Access Modifiers


    }
}
