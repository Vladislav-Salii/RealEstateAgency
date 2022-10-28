using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design
{
    [Serializable]
    public class Realty : Administration, INumerable
    {
        public string Number { get; set; }
        public string GetNumber()
        {
            return Number;
        }
        public Address Address { get; set; }
        public int Price { get; set; }
        public double Area { get; set; }
    }
}
