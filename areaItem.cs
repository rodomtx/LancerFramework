using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Templeate_LIN
{
    public class areaItem
    {

        public string descripcion;
        public string centroCostos;

        public areaItem(string _descripcion, string _centroCostos)
        {
            this.descripcion = _descripcion;
            this.centroCostos = _centroCostos;
        }
    }
}