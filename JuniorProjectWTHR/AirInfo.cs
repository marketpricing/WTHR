using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JuniorProjectWTHR
{
    class AirInfo
    {
        public class pollution
        {
            public int aqius { get; set; }
        }
        public class current
        {
            public pollution pollution { get; set; }
        }

        public class data
        {
            public current current { get; set; }
        }

        public class root
        {
            public data data { get; set; }
        }
    }
}
