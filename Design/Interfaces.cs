using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design
{
    interface IPrintable
    {
        string Print();
        
    }
    interface INumerable
    {
        string Number { get; set; }
        string GetNumber();
    }
    interface IFilter
    {
        bool Filter(object objFrom, object objTo);
    }
}
