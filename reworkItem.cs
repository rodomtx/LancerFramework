using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Templeate_LIN
{
    public class reworkItem
    {

        public int operacionSeq;
        public string lineaSolicita;
        public string owner;
        public int status;
        public DateTime fechaCreacion;
        public int journalGenerado;
        public string journalGeneradoMedida;
        public string journalGeneradoFlag;
        public int hospitalRecibo;
        public string hospitalReciboMedida;
        public string hospitalReciboFlag;
        public int fundidoraRecibo;
        public string fundidoraReciboMedida;
        public string fundidoraReciboFlag;
        public int retornoHospital;
        public string retornoHospitalMedida;
        public string retornoHospitalflag;


        public reworkItem(
            int _operacionSeq,
            string _lineaSolicita,
            string _owner,
            int _status,
            DateTime _fechaCreacion,
            int _journalGenerado,
            string _journalGeneradoMedida,
            string _journalGeneradoFlag,
            int _hospitalRecibo,
            string _hospitalReciboMedida,
            string _hospitalReciboFlag,
            int  _fundidoraRecibo,
            string _fundidoraReciboMedida,
            string _fundidoraReciboFlag,
            int _retornoHospital,
            string _retornoHospitalMedida,
            string _retornoHospitalflag

            )
        {
            this.operacionSeq = _operacionSeq;
            this.lineaSolicita = _lineaSolicita;
            this.owner = _owner;
            this.status = _status;
            this.fechaCreacion = _fechaCreacion;
            this.journalGenerado = _journalGenerado;
            this.journalGeneradoMedida = _journalGeneradoMedida;
            this.journalGeneradoFlag = _journalGeneradoFlag;
            this.hospitalRecibo = _hospitalRecibo;
            this.hospitalReciboMedida = _hospitalReciboMedida;
            this.hospitalReciboFlag = _hospitalReciboFlag;
            this.fundidoraRecibo = _fundidoraRecibo;
            this.fundidoraReciboMedida = _fundidoraReciboMedida;
            this.fundidoraReciboFlag = _fundidoraReciboFlag;
            this.retornoHospital = _retornoHospital;
            this.retornoHospitalMedida = _retornoHospitalMedida;
            this.retornoHospitalflag = _retornoHospitalflag;

        }

    }
}