using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Templeate_LIN
{
    public class REWORK
    {
        public int operacionSeq;
        public string lineaSolicita;
        public string originador;
        public DateTime fechaCreacion;
        
        public string machinePN;
        public string machineSN;
        public string coldPlateSN;
        
        public int journalGenerado;
        public string journalGeneradoMedida;
        public string journalGeneradoFlag;
        public int hospitalRecibo;
        public string hospitalReciboMedida;
        public string hospitalReciboFlag;
        
        public int fundidoraRecibo;
        public string fundidoraReciboMedida;
        public string fundidoraReciboFlag;

        public int revisionFundidora;
        public string revisionFundidoraMedida;
        public string revisionFundidoraFlag;

        public int retornoHospital;
        public string retornoHospitalMedida;
        public string retornoHospitalflag;

        public int inseccionHospital;
        public string inseccionHospitalMedida;
        public string inseccionHospitalflag;


        public REWORK(       
        int _operacionSeq,
        string _lineaSolicita,
        string _originador,
        DateTime _fechaCreacion,

        string _machinePN,
        string _machineSN,
        string _coldPlateSN,

        int _journalGenerado,
        string _journalGeneradoMedida,
        string _journalGeneradoFlag,
        
        int _hospitalRecibo,
        string _hospitalReciboMedida,
        string _hospitalReciboFlag,

        int _fundidoraRecibo,
        string _fundidoraReciboMedida,
        string _fundidoraReciboFlag,

        int _revisionFundidora,
        string _revisionFundidoraMedida,
        string _revisionFundidoraFlag,


        int _retornoHospital,
        string _retornoHospitalMedida,
        string _retornoHospitalflag,

        int _inseccionHospital,
        string _inseccionHospitalMedida,
        string _inseccionHospitalflag

            )
        {
        
        this.operacionSeq = _operacionSeq;
        this.lineaSolicita=_lineaSolicita;
        this.originador= _originador;
        this.fechaCreacion = _fechaCreacion;

        this.machinePN= _machinePN;
        this.machineSN= _machineSN;
        this.coldPlateSN= _coldPlateSN;

        this.journalGenerado = _journalGenerado;
        this.journalGeneradoMedida = _journalGeneradoMedida;
        this.journalGeneradoFlag = _journalGeneradoFlag;

        this.hospitalRecibo =_hospitalRecibo;
        this.hospitalReciboMedida =  _hospitalReciboMedida;
        this.hospitalReciboFlag = _hospitalReciboFlag;

        this.fundidoraRecibo = _fundidoraRecibo;
        this.fundidoraReciboMedida = _fundidoraReciboMedida;
        this.fundidoraReciboFlag = _fundidoraReciboFlag;

        this.revisionFundidora = _revisionFundidora;
        this.revisionFundidoraMedida = _revisionFundidoraMedida;
        this.revisionFundidoraFlag = _revisionFundidoraFlag;

        this.retornoHospital = _retornoHospital;
        this.retornoHospitalMedida = _retornoHospitalMedida;
        this.retornoHospitalflag = _retornoHospitalflag;

        this.inseccionHospital = _inseccionHospital;
        this.inseccionHospitalMedida = _inseccionHospitalMedida;
        this.inseccionHospitalflag = _inseccionHospitalflag;
    }

    }
}