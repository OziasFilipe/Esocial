using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using BibliotecaEsocial.Model.S5003;

namespace BibliotecaEsocial.Eventos.S5003
{
    class S5003
    {
        private eSocial eSocialEvt = new eSocial();
        private eSocialEvtBasesFGTS evtBasesFgts = new eSocialEvtBasesFGTS();
        private T_ideEmpregador t_ideEmpregador = new T_ideEmpregador();
        private eSocialEvtBasesFGTSIdeTrabalhador t_ideTrabalhador = new eSocialEvtBasesFGTSIdeTrabalhador();
        private T_ideEvento_retorno_trab t_ideEvento = new T_ideEvento_retorno_trab();
        private eSocialEvtBasesFGTSInfoFGTS infoFgts = new eSocialEvtBasesFGTSInfoFGTS();
        private eSocialEvtBasesFGTSInfoFGTSIdeEstab[] ideEstab = new eSocialEvtBasesFGTSInfoFGTSIdeEstab[1];

        private eSocialEvtBasesFGTSInfoFGTSIdeEstabIdeLotacao[] ideLotacao =
            new eSocialEvtBasesFGTSInfoFGTSIdeEstabIdeLotacao[1];

        private eSocialEvtBasesFGTSInfoFGTSIdeEstabIdeLotacaoInfoTrabFGTS[] infoTrabFgts =
            new eSocialEvtBasesFGTSInfoFGTSIdeEstabIdeLotacaoInfoTrabFGTS[1];

        private T_sucessaoVinc susSucessaoVinc = new T_sucessaoVinc();

        private eSocialEvtBasesFGTSInfoFGTSIdeEstabIdeLotacaoInfoTrabFGTSInfoBaseFGTS infoBaseFgts =
            new eSocialEvtBasesFGTSInfoFGTSIdeEstabIdeLotacaoInfoTrabFGTSInfoBaseFGTS();

        private eSocialEvtBasesFGTSInfoFGTSIdeEstabIdeLotacaoInfoTrabFGTSInfoBaseFGTSBasePerApur[] basePerApur =
            new eSocialEvtBasesFGTSInfoFGTSIdeEstabIdeLotacaoInfoTrabFGTSInfoBaseFGTSBasePerApur[1];

        private T_detRubrSusp[] detRubrSusp = new T_detRubrSusp[1];
        private T_detRubrSuspIdeProcessoFGTS[] infoProcessoFgts = new T_detRubrSuspIdeProcessoFGTS[1];

        private eSocialEvtBasesFGTSInfoFGTSIdeEstabIdeLotacaoInfoTrabFGTSInfoBaseFGTSInfoBasePerAntE[] infoBasePerAnt =
            new eSocialEvtBasesFGTSInfoFGTSIdeEstabIdeLotacaoInfoTrabFGTSInfoBaseFGTSInfoBasePerAntE[1];

        private eSocialEvtBasesFGTSInfoFGTSIdeEstabIdeLotacaoInfoTrabFGTSInfoBaseFGTSInfoBasePerAntEBasePerAntE[]
            basePerAntE =
                new eSocialEvtBasesFGTSInfoFGTSIdeEstabIdeLotacaoInfoTrabFGTSInfoBaseFGTSInfoBasePerAntEBasePerAntE[1];

        private eSocialEvtBasesFGTSInfoFGTSIdeEstabIdeLotacaoInfoTrabFGTSProcCS procCs =
            new eSocialEvtBasesFGTSInfoFGTSIdeEstabIdeLotacaoInfoTrabFGTSProcCS();

        private string id = string.Empty;
        private string nrInsc = string.Empty;
        private string perApur = string.Empty;
        private string cpfTrab = string.Empty;
        private sbyte tpInsc = 0;
        private sbyte indApuracao = 0;
        private string nrInscEstab = string.Empty;
        private sbyte tpInscEstab = 0;
        private string codLotacao = string.Empty;
        private string tpLotacao = string.Empty;
        private string nrInscLotacao = string.Empty;
        private sbyte tpInscLotacao = 0;
        private string matricula = string.Empty;
        private string codCateg = string.Empty;
        private string codRubr = string.Empty;
        private string ideTabRubr = string.Empty;
        private string nrProc = string.Empty;
        private string perRef = string.Empty;
        private TS_tpAcConv_FGTS tpAcConv = TS_tpAcConv_FGTS.E;



        public void s5003()
        {
            this.eSocialEvt.evtBasesFGTS = this.evtBasesFgts;
            this.evtBasesFgts.Id = this.id;
            this.t_ideEmpregador = this.t_ideEmpregador;
            this.evtBasesFgts.ideTrabalhador = this.t_ideTrabalhador;
            this.evtBasesFgts.ideEvento = this.t_ideEvento;
            this.evtBasesFgts.infoFGTS = this.infoFgts;

            this.t_ideEvento.indApuracao = this.indApuracao;
            this.t_ideEvento.perApur = this.perApur;

            this.t_ideEmpregador.nrInsc = this.nrInsc;
            this.t_ideEmpregador.tpInsc = this.tpInsc;

            this.t_ideTrabalhador.cpfTrab = this.cpfTrab;

            this.infoFgts.ideEstab = this.ideEstab;

            this.ideEstab[0] = new eSocialEvtBasesFGTSInfoFGTSIdeEstab();
            this.ideEstab[0].nrInsc = this.nrInscEstab;
            this.ideEstab[0].tpInsc = this.tpInscEstab;
            this.ideEstab[0].ideLotacao = this.ideLotacao;

            this.ideLotacao[0] = new eSocialEvtBasesFGTSInfoFGTSIdeEstabIdeLotacao();
            this.ideLotacao[0].codLotacao = this.codLotacao;
            this.ideLotacao[0].tpLotacao = this.tpLotacao;
            this.ideLotacao[0].tpInsc = this.tpInscLotacao;
            this.ideLotacao[0].nrInsc = this.nrInscLotacao;
            this.ideLotacao[0].infoTrabFGTS = this.infoTrabFgts;

            this.infoTrabFgts[0] = new eSocialEvtBasesFGTSInfoFGTSIdeEstabIdeLotacaoInfoTrabFGTS();
            this.infoTrabFgts[0].matricula = this.matricula;
            this.infoTrabFgts[0].codCateg = this.codCateg;
            this.infoTrabFgts[0].sucessaoVinc = this.susSucessaoVinc;
            this.infoTrabFgts[0].infoBaseFGTS = this.infoBaseFgts;

            this.infoBaseFgts.basePerApur = this.basePerApur;
            this.infoBaseFgts.infoBasePerAntE = this.infoBasePerAnt;

            this.basePerApur[0] =
                new eSocialEvtBasesFGTSInfoFGTSIdeEstabIdeLotacaoInfoTrabFGTSInfoBaseFGTSBasePerApur();
            this.basePerApur[0].tpValor = 0;
            this.basePerApur[0].indIncid = 0;
            this.basePerApur[0].detRubrSusp = this.detRubrSusp;

            this.detRubrSusp[0] = new T_detRubrSusp();
            this.detRubrSusp[0].codRubr = this.codRubr;
            this.detRubrSusp[0].ideTabRubr = this.ideTabRubr;
            this.detRubrSusp[0].ideProcessoFGTS = this.infoProcessoFgts;

            this.infoProcessoFgts[0] = new T_detRubrSuspIdeProcessoFGTS();
            this.infoProcessoFgts[0].nrProc = this.nrProc;

            this.infoBasePerAnt[0] =
                new eSocialEvtBasesFGTSInfoFGTSIdeEstabIdeLotacaoInfoTrabFGTSInfoBaseFGTSInfoBasePerAntE();
            this.infoBasePerAnt[0].perRef = this.perRef;
            this.infoBasePerAnt[0].tpAcConv = this.tpAcConv;
            this.infoBasePerAnt[0].basePerAntE = this.basePerAntE;

            this.basePerAntE[0] =
                new eSocialEvtBasesFGTSInfoFGTSIdeEstabIdeLotacaoInfoTrabFGTSInfoBaseFGTSInfoBasePerAntEBasePerAntE();
            this.basePerAntE[0].tpValorE = 0;
            this.basePerAntE[0].indIncidE = 0;
            this.basePerAntE[0].detRubrSusp = this.detRubrSusp;

            this.detRubrSusp[0].codRubr = this.codRubr;
            this.detRubrSusp[0].ideTabRubr = this.ideTabRubr;

            this.infoTrabFgts[0].procCS = this.procCs;

            XmlSerializer xml = new XmlSerializer(typeof(eSocial));
            xml.Serialize(Console.Out, eSocialEvt);
            Console.Read();
        }

    }
}
