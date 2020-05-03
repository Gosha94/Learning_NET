using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestingBoats.Classes
{
    class TestBoats
    {
        static void Main()
        {
            string xyz = "";
            Boat b1 = new Boat();
            SailBoat b2 = new SailBoat();
            Rowboat b3 = new Rowboat();
            b2.setLength(32);
            xyz = b1.move();
            xyz += b3.move();
            xyz += b2.move();

            System.Windows.Forms.MessageBox.Show(xyz);
        }        
    }
}
