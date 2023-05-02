using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using BibliotecaEsocial.Model.S1270;

namespace BibliotecaEsocial.Eventos.S1270
{
    class S1270
    {
        private eSocial eSocialEvt = new eSocial();
        private eSocialEvtContratAvNP evtContrat = new eSocialEvtContratAvNP();
        private T_ideEvento_folha_mensal t_ideEvento = new T_ideEvento_folha_mensal();
        private T_ideEmpregador t_ideEmpregador = new T_ideEmpregador();
        private eSocialEvtContratAvNPRemunAvNP[] remunAvNp = new eSocialEvtContratAvNPRemunAvNP[1];

        private string id = string.Empty;
        private string perApur = string.Empty;
        private string nrInsc = string.Empty;
        private sbyte indGuia = 0;
        private sbyte tpInsc = 0;
        private string nrInsc2 = string.Empty;
        private string codLotacao = string.Empty;
        private sbyte tpInsc2 = 0;

        public void s1270()
        {
            this.eSocialEvt = this.eSocialEvt;
            this.eSocialEvt.evtContratAvNP = this.evtContrat;

            this.evtContrat.Id = this.id;
            this.evtContrat.ideEvento = this.t_ideEvento;
            this.evtContrat.ideEmpregador = this.t_ideEmpregador;
            this.evtContrat.remunAvNP = this.remunAvNp;

            this.t_ideEvento.perApur = this.perApur;
            this.t_ideEvento.indGuia = this.indGuia;

            this.t_ideEmpregador.nrInsc = this.nrInsc;
            this.t_ideEmpregador.tpInsc = this.tpInsc;

            this.remunAvNp[0] = new eSocialEvtContratAvNPRemunAvNP();
            this.remunAvNp[0].tpInsc = this.tpInsc2;
            this.remunAvNp[0].nrInsc = this.nrInsc2;
            this.remunAvNp[0].codLotacao= this.codLotacao;

            XmlSerializer xml = new XmlSerializer(typeof(eSocial));
            xml.Serialize(Console.Out, eSocialEvt);
            Console.Read();
        }
    }
}
