using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleKeySaver.Models
{
    [Serializable]
    class Resource
    {
        public string ResourceName { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Link { get; set; }
        public DateTime Modified { get; set; }
    }
}
