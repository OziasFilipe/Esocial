using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using BibliotecaEsocial.Model.S2501;
using Microsoft.SqlServer.Server;

namespace BibliotecaEsocial.Eventos.S2501
{
    class S2501
    {
        private eSocial eSocialEvt = new eSocial();
        private eSocialEvtContProc evtContProc = new eSocialEvtContProc();
        private T_ideEvento_trab t_ideEvento = new T_ideEvento_trab();
        private eSocialEvtContProcIdeEmpregador t_ideEmpregador = new eSocialEvtContProcIdeEmpregador();
        private eSocialEvtContProcIdeProc ideProc = new eSocialEvtContProcIdeProc();
        private eSocialEvtContProcIdeTrab[] ideTrab = new eSocialEvtContProcIdeTrab[1];
        private eSocialEvtContProcIdeTrabCalcTrib[] calcTrib = new eSocialEvtContProcIdeTrabCalcTrib[1];

        private eSocialEvtContProcIdeTrabCalcTribInfoCRContrib[] infoCrContrib =
            new eSocialEvtContProcIdeTrabCalcTribInfoCRContrib[1];

        private eSocialEvtContProcIdeTrabInfoCRIRRF[] infoCrirrfs = new eSocialEvtContProcIdeTrabInfoCRIRRF[1];
        private eSocialEvtContProcIdeTrabInfoCRIRRFTpCR tpCr = new eSocialEvtContProcIdeTrabInfoCRIRRFTpCR();

        private string id = string.Empty;
        private string nrInsc = string.Empty;
        private sbyte tpInsc = 0;
        private string nrProcTrab = string.Empty;
        private string perApurPgto = string.Empty;
        private string cpfTrab = string.Empty;
        private string perRef = string.Empty;
        private string tpCR = string.Empty;

        public void s2501()
        {
            this.eSocialEvt = this.eSocialEvt;
            this.eSocialEvt.evtContProc = this.evtContProc;
            this.evtContProc.Id = this.id;
            this.evtContProc.ideEvento = this.t_ideEvento;
            this.evtContProc.ideEmpregador = this.t_ideEmpregador;
            this.evtContProc.ideProc = this.ideProc;
            this.evtContProc.ideTrab = this.ideTrab;

            this.t_ideEmpregador.nrInsc = this.nrInsc;
            this.t_ideEmpregador.tpInsc = this.tpInsc;

            this.ideProc.nrProcTrab = this.nrProcTrab;
            this.ideProc.perApurPgto = this.perApurPgto;

            this.ideTrab[0] = new eSocialEvtContProcIdeTrab();
            this.ideTrab[0].cpfTrab = this.cpfTrab;
            this.ideTrab[0].calcTrib = this.calcTrib;

            this.calcTrib[0] = new eSocialEvtContProcIdeTrabCalcTrib();
            this.calcTrib[0].perRef = this.perRef;
            this.calcTrib[0].infoCRContrib = this.infoCrContrib;

            this.infoCrContrib[0] = new eSocialEvtContProcIdeTrabCalcTribInfoCRContrib();
            this.infoCrContrib[0].tpCR = this.tpCR;

            this.ideTrab[0].infoCRIRRF = this.infoCrirrfs;

            this.infoCrirrfs[0] = new eSocialEvtContProcIdeTrabInfoCRIRRF();
            this.infoCrirrfs[0].tpCR = this.tpCr;

            XmlSerializer xml = new XmlSerializer(typeof(eSocial));
            xml.Serialize(Console.Out, eSocialEvt);
            Console.Read();
        }
    }
}
