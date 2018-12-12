using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex36_Observer_Pattern_2
{
    public class Student : Person, IStudent
    {
        private Academy academy;
        private string _message;

        public string Message
        {
            get
            {
                return _message;
            }
            set
            {
                _message = value;
            }
        }

        public Student (Academy _academy, string name)
        {
            academy = _academy;
            _name = name;
        }

        public void Update()
        {
            Message = academy.Message;
            Console.WriteLine("Studerende " + Name + " fik nyhed " + Message + " fra akademiet " + academy.Name);
        }
    }
}
