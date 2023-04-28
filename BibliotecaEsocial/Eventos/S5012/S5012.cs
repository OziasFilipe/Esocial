using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using BibliotecaEsocial.Model.S5012;

namespace BibliotecaEsocial.Eventos.S5012
{
    class S5012
    {
        private eSocial eSocialEvt = new eSocial();
        private eSocialEvtIrrf evtIrrf = new eSocialEvtIrrf();
        private T_ideEvento_retorno_mensal t_ideEvento = new T_ideEvento_retorno_mensal();
        private T_ideEmpregador t_ideEmpregador = new T_ideEmpregador();
        private eSocialEvtIrrfInfoIRRF infoIrrf = new eSocialEvtIrrfInfoIRRF();
        private eSocialEvtIrrfInfoIRRFInfoCRMen[] infoCrMen = new eSocialEvtIrrfInfoIRRFInfoCRMen[1];
        private eSocialEvtIrrfInfoIRRFInfoCRDia[] infoCrDia = new eSocialEvtIrrfInfoIRRFInfoCRDia[1];

        private string id = string.Empty;
        private string perApur = string.Empty;
        private string nrInsc = string.Empty;
        private sbyte tpInsc = 0;
        private sbyte perApurDia = 0;
        private TS_CRDia CRDia = new TS_CRDia();
        private TS_CRMen CRMen = new TS_CRMen();
        public void s5012()
        {
            this.eSocialEvt.evtIrrf = this.evtIrrf;
            this.evtIrrf.Id = this.id;
            this.evtIrrf.ideEvento = this.t_ideEvento;
            this.evtIrrf.ideEmpregador = this.t_ideEmpregador;
            this.evtIrrf.infoIRRF = this.infoIrrf;

            this.t_ideEvento.perApur = this.perApur;

            this.t_ideEmpregador.nrInsc = this.nrInsc;
            this.t_ideEmpregador.tpInsc = this.tpInsc;

            this.infoIrrf.infoCRMen = this.infoCrMen;
            this.infoIrrf.infoCRDia = this.infoCrDia;

            this.infoCrDia[0] = new eSocialEvtIrrfInfoIRRFInfoCRDia();
            this.infoCrDia[0].perApurDia = this.perApurDia;
            this.infoCrDia[0].CRDia = this.CRDia;

            this.infoCrMen[0] = new eSocialEvtIrrfInfoIRRFInfoCRMen();
            this.infoCrMen[0].CRMen = this.CRMen;

            XmlSerializer xml = new XmlSerializer(typeof(eSocial));
            xml.Serialize(Console.Out, eSocialEvt);
            Console.Read();
        }
    }
}
