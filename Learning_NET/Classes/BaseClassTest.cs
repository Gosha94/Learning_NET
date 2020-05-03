using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Learning_NET.Classes
{
    class BaseClassTest
    {
        public BaseClassTest(string baseClassNeedsThis)
        {
            MessageBox.Show("This is the base class: " + baseClassNeedsThis);
        }
    }
}
