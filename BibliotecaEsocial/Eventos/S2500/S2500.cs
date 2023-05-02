using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using BibliotecaEsocial.Model.S2500;

namespace BibliotecaEsocial.Eventos.S2500
{
    class S2500
    {
        private eSocial eSocialEvt = new eSocial();
        private eSocialEvtProcTrab evtProcTrab = new eSocialEvtProcTrab();
        private eSocialEvtProcTrabInfoProcesso infoProcesso = new eSocialEvtProcTrabInfoProcesso();
        private eSocialEvtProcTrabIdeEmpregador t_ideEmpregador = new eSocialEvtProcTrabIdeEmpregador();
        private T_ideEvento_trab t_ideEvento = new T_ideEvento_trab();
        private eSocialEvtProcTrabIdeTrab idetrab = new eSocialEvtProcTrabIdeTrab();
        private eSocialEvtProcTrabIdeEmpregadorIdeResp ideResp = new eSocialEvtProcTrabIdeEmpregadorIdeResp();
        private eSocialEvtProcTrabInfoProcessoDadosCompl dadosCompl = new eSocialEvtProcTrabInfoProcessoDadosCompl();

        private eSocialEvtProcTrabInfoProcessoDadosComplInfoCCP infoCcp =
            new eSocialEvtProcTrabInfoProcessoDadosComplInfoCCP();

        private eSocialEvtProcTrabInfoProcessoDadosComplInfoProcJud infoProcJud =
            new eSocialEvtProcTrabInfoProcessoDadosComplInfoProcJud();

        private eSocialEvtProcTrabIdeTrabDependente[] depende = new eSocialEvtProcTrabIdeTrabDependente[1];
        private eSocialEvtProcTrabIdeTrabInfoContr[] infoContr = new eSocialEvtProcTrabIdeTrabInfoContr[1];

        private eSocialEvtProcTrabIdeTrabInfoContrInfoCompl infoCompl =
            new eSocialEvtProcTrabIdeTrabInfoContrInfoCompl();

        private eSocialEvtProcTrabIdeTrabInfoContrInfoComplRemuneracao[] remuneracao =
            new eSocialEvtProcTrabIdeTrabInfoContrInfoComplRemuneracao[1];

        private eSocialEvtProcTrabIdeTrabInfoContrInfoComplInfoVinc infoVinc =
            new eSocialEvtProcTrabIdeTrabInfoContrInfoComplInfoVinc();

        private eSocialEvtProcTrabIdeTrabInfoContrInfoComplInfoVincDuracao duracao =
            new eSocialEvtProcTrabIdeTrabInfoContrInfoComplInfoVincDuracao();

        private eSocialEvtProcTrabIdeTrabInfoContrInfoComplInfoVincObservacoes[] observacoes =
            new eSocialEvtProcTrabIdeTrabInfoContrInfoComplInfoVincObservacoes[1];

        private eSocialEvtProcTrabIdeTrabInfoContrInfoComplInfoVincSucessaoVinc sucessaoVinc =
            new eSocialEvtProcTrabIdeTrabInfoContrInfoComplInfoVincSucessaoVinc();

        private eSocialEvtProcTrabIdeTrabInfoContrInfoComplInfoVincInfoDeslig infoDeslig =
            new eSocialEvtProcTrabIdeTrabInfoContrInfoComplInfoVincInfoDeslig();

        private eSocialEvtProcTrabIdeTrabInfoContrInfoComplInfoTerm infoTerm =
            new eSocialEvtProcTrabIdeTrabInfoContrInfoComplInfoTerm();

        private eSocialEvtProcTrabIdeTrabInfoContrMudCategAtiv[] mudCategAtiva =
            new eSocialEvtProcTrabIdeTrabInfoContrMudCategAtiv[1];

        private eSocialEvtProcTrabIdeTrabInfoContrUnicContr[] unicContrs =
            new eSocialEvtProcTrabIdeTrabInfoContrUnicContr[1];

        private eSocialEvtProcTrabIdeTrabInfoContrIdeEstab ideEstab = new eSocialEvtProcTrabIdeTrabInfoContrIdeEstab();

        private eSocialEvtProcTrabIdeTrabInfoContrIdeEstabInfoVlr infoVlr =
            new eSocialEvtProcTrabIdeTrabInfoContrIdeEstabInfoVlr();

        private eSocialEvtProcTrabIdeTrabInfoContrIdeEstabInfoVlrIdePeriodo[] idePeriodo =
            new eSocialEvtProcTrabIdeTrabInfoContrIdeEstabInfoVlrIdePeriodo[1];

        private eSocialEvtProcTrabIdeTrabInfoContrIdeEstabInfoVlrIdePeriodoBaseCalculo baseCalculo =
            new eSocialEvtProcTrabIdeTrabInfoContrIdeEstabInfoVlrIdePeriodoBaseCalculo();

        private eSocialEvtProcTrabIdeTrabInfoContrIdeEstabInfoVlrIdePeriodoBaseCalculoInfoAgNocivo infoAgNocivo =
            new eSocialEvtProcTrabIdeTrabInfoContrIdeEstabInfoVlrIdePeriodoBaseCalculoInfoAgNocivo();

        private eSocialEvtProcTrabIdeTrabInfoContrIdeEstabInfoVlrIdePeriodoInfoFGTS infoFgts =
            new eSocialEvtProcTrabIdeTrabInfoContrIdeEstabInfoVlrIdePeriodoInfoFGTS();

        private eSocialEvtProcTrabIdeTrabInfoContrIdeEstabInfoVlrIdePeriodoBaseMudCateg baseMudCateg =
            new eSocialEvtProcTrabIdeTrabInfoContrIdeEstabInfoVlrIdePeriodoBaseMudCateg();

        private string id = string.Empty;
        private string nrInsc = string.Empty;
        private sbyte tpInsc = 0;
        private string nrProcTrab = string.Empty;
        private string cpfTrab = string.Empty;
        private string cpfDep = string.Empty;
        private string matricula = string.Empty;
        private string codCateg = string.Empty;
        private DateTime dtInicio = DateTime.Now;
        private DateTime dtRemun = DateTime.Now;
        private DateTime dtMudCategAtiv = DateTime.Now;
        private string matUnic = string.Empty;
        private string codCateg2 = string.Empty;
        private string perRef = string.Empty;
        private DateTime dtInicio2 = DateTime.Now;

        public void s2500()
        {
            this.eSocialEvt = this.eSocialEvt;
            this.eSocialEvt.evtProcTrab = this.evtProcTrab;
            this.evtProcTrab.Id = this.id;
            this.evtProcTrab.infoProcesso = this.infoProcesso;
            this.evtProcTrab.ideEmpregador = this.t_ideEmpregador;
            this.evtProcTrab.ideEvento = this.t_ideEvento;
            this.evtProcTrab.ideTrab = this.idetrab;

            this.t_ideEmpregador.nrInsc = this.nrInsc;
            this.t_ideEmpregador.tpInsc = this.tpInsc;
            this.t_ideEmpregador.ideResp = this.ideResp;

            this.infoProcesso.dadosCompl = this.dadosCompl;
            this.infoProcesso.nrProcTrab = this.nrProcTrab;

            this.dadosCompl.infoProcJud = this.infoProcJud;
            this.dadosCompl.infoCCP = this.infoCcp;

            this.idetrab.cpfTrab = this.cpfTrab;
            this.idetrab.dependente = this.depende;

            this.depende[0] = new eSocialEvtProcTrabIdeTrabDependente();
            this.depende[0].cpfDep = this.cpfDep;

            this.idetrab.infoContr = this.infoContr;

            this.infoContr[0] = new eSocialEvtProcTrabIdeTrabInfoContr();
            this.infoContr[0].matricula = this.matricula;
            this.infoContr[0].codCateg = this.codCateg;
            this.infoContr[0].dtInicio = this.dtInicio;
            this.infoContr[0].infoCompl = this.infoCompl;

            this.infoCompl.remuneracao = this.remuneracao;

            this.remuneracao[0] = new eSocialEvtProcTrabIdeTrabInfoContrInfoComplRemuneracao();
            this.remuneracao[0].dtRemun = this.dtRemun;

            this.infoCompl.infoVinc = this.infoVinc;

            this.infoVinc.duracao = this.duracao;
            this.infoVinc.observacoes = this.observacoes;
            this.infoVinc.sucessaoVinc = this.sucessaoVinc;
            this.infoVinc.infoDeslig = this.infoDeslig;

            this.infoCompl.infoTerm = this.infoTerm;

            this.infoContr[0].mudCategAtiv = this.mudCategAtiva;

            this.mudCategAtiva[0] = new eSocialEvtProcTrabIdeTrabInfoContrMudCategAtiv();
            this.mudCategAtiva[0].dtMudCategAtiv = this.dtMudCategAtiv;

            this.infoContr[0].unicContr = this.unicContrs;

            this.unicContrs[0] = new eSocialEvtProcTrabIdeTrabInfoContrUnicContr();
            this.unicContrs[0].matUnic = this.matUnic;
            this.unicContrs[0].codCateg = this.codCateg2;
            this.unicContrs[0].dtInicio= this.dtInicio2;

            this.infoContr[0].ideEstab = this.ideEstab;

            this.ideEstab.infoVlr = this.infoVlr;

            this.infoVlr.idePeriodo = this.idePeriodo;

            this.idePeriodo[0] = new eSocialEvtProcTrabIdeTrabInfoContrIdeEstabInfoVlrIdePeriodo();
            this.idePeriodo[0].perRef = this.perRef;
            this.idePeriodo[0].baseCalculo = this.baseCalculo;

            this.baseCalculo.infoAgNocivo = this.infoAgNocivo;

            this.idePeriodo[0].infoFGTS = this.infoFgts;
            this.idePeriodo[0].baseMudCateg = this.baseMudCateg;


            XmlSerializer xml = new XmlSerializer(typeof(eSocial));
            xml.Serialize(Console.Out, eSocialEvt);
            Console.ReadLine();
        }
    }
}
