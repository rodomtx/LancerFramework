using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Templeate_LIN
{
    public class BUSQUEDARW
    {

        public int operacion;
        public string creator;
        public DateTime creacion;
        public string machinePN;
        public string machineSN;
        public string coldplateSN;
        public string descripcion;

        public BUSQUEDARW(  int _operacion,
                            string _creator,
                            DateTime _creacion,
                            string _machinePN,
                            string _machineSN,
                            string _coldplateSN,
                            string _descripcion
                         )
        {
            this.operacion = _operacion;
            this.creator = _creator;
            this.creacion = _creacion;
            this.machinePN = _machinePN;
            this.machineSN = _machineSN;
            this.coldplateSN = _coldplateSN;
            this.descripcion = _descripcion;


        }

}
}