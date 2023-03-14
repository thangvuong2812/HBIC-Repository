using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BusinessObject
{
    public class BOAccountNumber
    {
        public int Id { get; set; }
        public string Label { get; set; }
        public string HexColor { get; set; }
        public string ColorName { get; set; }
        public string HoverColor { get; set; }
        public double AccountNumber { get; set; }
    }
}
