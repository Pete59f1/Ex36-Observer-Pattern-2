using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex36_Observer_Pattern_2
{
    public class Academy : Orginazation, IAcademy
    {
        private List<IStudent> students = new List<IStudent>();
        private string message;

        public string Message
        {
            get
            {
                return message;
            }
            set
            {
                message = value;
                Notify();
            }
        }

        public Academy (string _name, string _address)
        {
            name = _name;
            Address = _address;
        }

        public void Attach(IStudent student)
        {
            students.Add(student);
        }
        public void Detach(IStudent student)
        {
            students.Remove(student);
        }
        public void Notify()
        {
            foreach (Student stu in students)
            {
                stu.Update();
            }
        }
    }
}
