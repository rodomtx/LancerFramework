using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Templeate_LIN
{
    public class REWORKDETAILS
    {
        public int operacionSeq;

        public string area;
        public string originador;
        public string machinePN;
        public string machineSN;
        public string coldplateSN;
        public string descripcion;

        public DateTime fechaCreacion;
        public DateTime fechaJournal;
        public DateTime ingresoHospital;
        public DateTime ingresFundidora;
        public DateTime revisionFundidora;
        public DateTime retornoHospital;
        public DateTime inspeccionFinal;
        public DateTime entregada;

        public REWORKDETAILS(

                                int _operacionSeq,

                                string _area,
                                string _originador,
                                string _machinePN,
                                string _machineSN,
                                string _coldplateSN,
                                string _descripcion,

                                DateTime _fechaCreacion,
                                DateTime _fechaJournal,
                                DateTime _ingresoHospital,
                                DateTime _ingresoFundidora,
                                DateTime _revisionFundidora,
                                DateTime _retornoHospital,
                                DateTime _inspeccionFinal,
                                DateTime _entregada 
                    )
            {


            this.operacionSeq = _operacionSeq;
            
            this.area = _area;
            this.originador = _originador;
            this.machinePN = _machinePN;
            this.machineSN = _machineSN;
            this.coldplateSN = _coldplateSN;
            this.descripcion = _descripcion;

            this.fechaCreacion = _fechaCreacion;
            this.fechaJournal = _fechaJournal;
            this.ingresoHospital = _ingresoHospital;
            this.ingresFundidora = _ingresoFundidora;
            this.revisionFundidora = _revisionFundidora;
            this.retornoHospital = _retornoHospital;
            this.inspeccionFinal = _inspeccionFinal;
            this.entregada = _entregada;


        }
    }
}








