using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Entidad
{
    public class BaseNodo
    {
        // NOTA si tienes intensión de agregar más nodos se puede agregar estos 2 campos
        // Public Property NodoPadre As Integer
        // Public Property NodoHijo As Integer
        public string Id { get; set; }
        public string Name { get; set; }
        public bool Value { get; set; }
    }
}
