using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Templeate_LIN
{
    public class AREA
    {

        public string descripcion;
        public string centroCostos;

        public AREA(string _descripcion, string _centroCostos)
        {
            this.descripcion = _descripcion;
            this.centroCostos = _centroCostos;
        }
    }
}