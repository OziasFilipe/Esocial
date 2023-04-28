using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using BibliotecaEsocial.Model.S5013;

namespace BibliotecaEsocial.Eventos.S5013
{
    class S5013
    {
        private eSocial eSocialEvt = new eSocial();
        private eSocialEvtFGTS evtFgts = new eSocialEvtFGTS();
        private T_ideEmpregador t_ideEmpregador = new T_ideEmpregador();
        private T_ideEvento_retorno_contrib t_ideEvento = new T_ideEvento_retorno_contrib();
        private eSocialEvtFGTSInfoFGTS infoFgts = new eSocialEvtFGTSInfoFGTS();
        private eSocialEvtFGTSInfoFGTSIdeEstab[] ideEstab = new eSocialEvtFGTSInfoFGTSIdeEstab[1];
        private eSocialEvtFGTSInfoFGTSIdeEstabIdeLotacao[] ideLotacao = new eSocialEvtFGTSInfoFGTSIdeEstabIdeLotacao[1];

        private eSocialEvtFGTSInfoFGTSIdeEstabIdeLotacaoInfoBaseFGTS infoBaseFgts =
            new eSocialEvtFGTSInfoFGTSIdeEstabIdeLotacaoInfoBaseFGTS();

        private eSocialEvtFGTSInfoFGTSIdeEstabIdeLotacaoInfoBaseFGTSBasePerApur[] basePerApur =
            new eSocialEvtFGTSInfoFGTSIdeEstabIdeLotacaoInfoBaseFGTSBasePerApur[1];

        private eSocialEvtFGTSInfoFGTSIdeEstabIdeLotacaoInfoBaseFGTSInfoBasePerAntE[] infoBasePerAnt =
            new eSocialEvtFGTSInfoFGTSIdeEstabIdeLotacaoInfoBaseFGTSInfoBasePerAntE[1];

        private eSocialEvtFGTSInfoFGTSIdeEstabIdeLotacaoInfoBaseFGTSInfoBasePerAntEBasePerAntE[] basePerAntE =
            new eSocialEvtFGTSInfoFGTSIdeEstabIdeLotacaoInfoBaseFGTSInfoBasePerAntEBasePerAntE[1];


        private string id = String.Empty;
        private string nrInsc = string.Empty;
        private sbyte tpInsc = 0;
        private string perApur = string.Empty;
        private sbyte indApuracao = 0;
        private string cpfBenef = string.Empty;
        private string nrInscEstab = string.Empty;
        private string codLotacao = string.Empty;
        private string tpLotacao = string.Empty;
        private string nrInscLotacao = string.Empty;
        private sbyte tpInscEstab = 0;
        private sbyte tpInscLotacao = 0;
        private sbyte tpValor = 0;
        private sbyte indIncid = 0;
        private string perRef = string.Empty;
        private TS_tpAcConv_FGTS tpAcConv = TS_tpAcConv_FGTS.E;
        private sbyte tpValorE = 0;
        private sbyte indIncidE = 0;
        public void s5013()
        {
            this.eSocialEvt.evtFGTS = this.evtFgts;
            this.evtFgts.Id = this.id;
            this.evtFgts.ideEmpregador = this.t_ideEmpregador;
            this.evtFgts.ideEvento = this.t_ideEvento;
            this.evtFgts.infoFGTS = this.infoFgts;

            this.t_ideEvento.perApur = this.perApur;
            this.t_ideEvento.indApuracao = this.indApuracao;

            this.t_ideEmpregador.nrInsc = this.nrInsc;
            this.t_ideEmpregador.tpInsc = this.tpInsc;

            this.infoFgts.ideEstab = this.ideEstab;

            this.ideEstab[0] = new eSocialEvtFGTSInfoFGTSIdeEstab();
            this.ideEstab[0].nrInsc = this.nrInscEstab;
            this.ideEstab[0].tpInsc = this.tpInscEstab;
            this.ideEstab[0].ideLotacao = this.ideLotacao;

            this.ideLotacao[0] = new eSocialEvtFGTSInfoFGTSIdeEstabIdeLotacao();
            this.ideLotacao[0].codLotacao = this.codLotacao;
            this.ideLotacao[0].tpLotacao = this.tpLotacao;
            this.ideLotacao[0].tpInsc = this.tpInscLotacao;
            this.ideLotacao[0].nrInsc = this.nrInscLotacao;
            this.ideLotacao[0].infoBaseFGTS = this.infoBaseFgts;

            this.infoBaseFgts.basePerApur = this.basePerApur;

            this.basePerApur[0] = new eSocialEvtFGTSInfoFGTSIdeEstabIdeLotacaoInfoBaseFGTSBasePerApur();
            this.basePerApur[0].tpValor = this.tpValor;
            this.basePerApur[0].indIncid = this.indIncid;

            this.infoBaseFgts.infoBasePerAntE = this.infoBasePerAnt;

            this.infoBasePerAnt[0] = new eSocialEvtFGTSInfoFGTSIdeEstabIdeLotacaoInfoBaseFGTSInfoBasePerAntE();
            this.infoBasePerAnt[0].perRef = this.perRef;
            this.infoBasePerAnt[0].tpAcConv = this.tpAcConv;
            this.infoBasePerAnt[0].basePerAntE = this.basePerAntE;

            this.basePerAntE[0] = new eSocialEvtFGTSInfoFGTSIdeEstabIdeLotacaoInfoBaseFGTSInfoBasePerAntEBasePerAntE();
            this.basePerAntE[0].tpValorE = this.tpValorE;
            this.basePerAntE[0].indIncidE = this.indIncidE;

            XmlSerializer xml = new XmlSerializer(typeof(eSocial));
            xml.Serialize(Console.Out, eSocialEvt);
            Console.Read();
        }
    }
}
