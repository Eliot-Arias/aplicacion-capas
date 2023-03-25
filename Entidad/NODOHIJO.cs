using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Entidad
{
    public class NODOHIJO : BaseNodo
    {
        public List<NODOHIJO> SubNodo { get; set; }
    }
}
