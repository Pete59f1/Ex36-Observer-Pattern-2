using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex36_Observer_Pattern_2
{
    public interface IAcademy
    {
        void Attach(IStudent student);
        void Detach(IStudent student);
        void Notify();
    }
}
