using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AggDatosPersonasATxt
{
    public interface IPersona
    {
        string Name { get; set; }
        int Age { get; set; }
        string Location { get; set; }  
    }
}
