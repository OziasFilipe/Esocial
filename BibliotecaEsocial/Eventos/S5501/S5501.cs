using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using BibliotecaEsocial.Model.S5501;

namespace BibliotecaEsocial.Eventos.S5501
{
    class S5501
    {
        private eSocial eSocialEvt = new eSocial();
        private eSocialEvtTribProcTrab evtTribProc = new eSocialEvtTribProcTrab();
        private eSocialEvtTribProcTrabIdeEvento t_ideEvento = new eSocialEvtTribProcTrabIdeEvento();
        private eSocialEvtTribProcTrabIdeEmpregador t_ideEmpregador = new eSocialEvtTribProcTrabIdeEmpregador();
        private eSocialEvtTribProcTrabIdeProc ideProc = new eSocialEvtTribProcTrabIdeProc();

        private eSocialEvtTribProcTrabIdeProcInfoTributos[] infoTributos =
            new eSocialEvtTribProcTrabIdeProcInfoTributos[1];

        private eSocialEvtTribProcTrabIdeProcInfoTributosInfoCRContrib[] infoCrContrib =
            new eSocialEvtTribProcTrabIdeProcInfoTributosInfoCRContrib[1];

        private eSocialEvtTribProcTrabIdeProcInfoCRIRRF[] infoCrirrf = new eSocialEvtTribProcTrabIdeProcInfoCRIRRF[1];

        private string id = string.Empty;
        private string nrInsc = string.Empty;
        private sbyte tpInsc = 0;
        private string nrProcTrab = string.Empty;
        private string perApur = string.Empty;
        private string perRef = string.Empty;
        private string tpCR = string.Empty;
        private string tpCr = string.Empty;

        public void s5501()
        {
            this.eSocialEvt = this.eSocialEvt;
            this.eSocialEvt.evtTribProcTrab = this.evtTribProc;

            this.evtTribProc.Id = this.id;
            this.evtTribProc.ideEvento = this.t_ideEvento;
            this.evtTribProc.ideEmpregador = this.t_ideEmpregador;
            this.evtTribProc.ideProc = this.ideProc;

            this.t_ideEmpregador.nrInsc = this.nrInsc;
            this.t_ideEmpregador.tpInsc = this.tpInsc;

            this.ideProc.nrProcTrab = this.nrProcTrab;
            this.ideProc.perApur = this.perApur;
            this.ideProc.infoTributos = this.infoTributos;

            this.infoTributos[0] = new eSocialEvtTribProcTrabIdeProcInfoTributos();
            this.infoTributos[0].perRef = this.perRef;
            this.infoTributos[0].infoCRContrib = this.infoCrContrib;

            this.infoCrContrib[0] = new eSocialEvtTribProcTrabIdeProcInfoTributosInfoCRContrib();
            this.infoCrContrib[0].tpCR = this.tpCR;

            this.ideProc.infoCRIRRF = this.infoCrirrf;

            this.infoCrirrf[0] = new eSocialEvtTribProcTrabIdeProcInfoCRIRRF();
            this.infoCrirrf[0].tpCR = this.tpCr;

            XmlSerializer xml = new XmlSerializer(typeof(eSocial));
            xml.Serialize(Console.Out, eSocialEvt);
            Console.Read();
        }
    }
}
