using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnInterfaces
{
    class Bee : IStingPatrol
    {
        public int AlertLevel
        {
            get { return 5; }
        }
        public int StingerLength { get; set; }

        public bool LookForEnemies()
        {
            return true;
        }

        public int SharpenStinger(int length)
        {
            return length;
        }
    }
}
