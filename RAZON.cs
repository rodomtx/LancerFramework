using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Templeate_LIN
{
    public class RAZON
    {

        public int codigo;
        public string descripcion;

        public RAZON(int _codigo, string _descripcion )
        {
            this.codigo = _codigo ;
            this.descripcion = _descripcion;
        }
    }
}