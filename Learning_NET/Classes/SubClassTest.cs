using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Learning_NET.Classes
{
    class SubClassTest : BaseClassTest
    {
        public SubClassTest(string baseClassNeedsThis, int anotherValue) :base(baseClassNeedsThis)
        { 
            MessageBox.Show("This is the subclass: " + baseClassNeedsThis
            + " and " + anotherValue);
        }
    }
}
