using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coursework
{
    internal class Price
    {
        public Price()
        {

        }
        public string Group_number { get; set; }
        public string Duration { get; set; }
        public int Child_weekend { get; set; }
        public int Child_weekdays { get; set; }
        public int Adult_weekend { get; set; }
        public int Adult_weekdays { get; set; }

    }
}