using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using BibliotecaEsocial.Model.S1020;


namespace BibliotecaEsocial.Eventos.S1020
{
    class S1020
    {
        private eSocial eSocialEvt = new eSocial();
        private eSocialEvtTabLotacao evtTabLotacao = new eSocialEvtTabLotacao();
        private T_ideEvento_evtTab t_ideEvento = new T_ideEvento_evtTab();
        private T_ideEmpregador t_ideEmpregador = new T_ideEmpregador();
        private eSocialEvtTabLotacaoInfoLotacao infoLotacao = new eSocialEvtTabLotacaoInfoLotacao();
        private eSocialEvtTabLotacaoInfoLotacaoInclusao inclusao = new eSocialEvtTabLotacaoInfoLotacaoInclusao();
        private eSocialEvtTabLotacaoInfoLotacaoExclusao exclusao = new eSocialEvtTabLotacaoInfoLotacaoExclusao();
        private eSocialEvtTabLotacaoInfoLotacaoAlteracao alteracao = new eSocialEvtTabLotacaoInfoLotacaoAlteracao();
        private T_ideLotacao ideLotacao = new T_ideLotacao();
        private T_dadosLotacao dadosLotacao = new T_dadosLotacao();
        private T_dadosLotacaoFpasLotacao fpasLotacao = new T_dadosLotacaoFpasLotacao();
        private T_dadosLotacaoInfoEmprParcial infoEmprParcial = new T_dadosLotacaoInfoEmprParcial();
        private T_dadosLotacaoDadosOpPort dadosOpPort = new T_dadosLotacaoDadosOpPort();
        private T_dadosLotacaoFpasLotacaoProcJudTerceiro[] infoProcJudTerceiros =
            new T_dadosLotacaoFpasLotacaoProcJudTerceiro[1];

        private T_novaValidade novaValidade = new T_novaValidade();

        private string id = string.Empty;
        private string nrInsc = string.Empty;
        private sbyte tpInsc = 0;
        private string codLotacao = string.Empty;
        private string iniValid = string.Empty;
        private string fimValid = string.Empty;
        private string codTerc = string.Empty;
        private string nrProcJud = string.Empty;
        public void s1020()
        {
           this.eSocialEvt = this.eSocialEvt;
            this.eSocialEvt.evtTabLotacao = this.evtTabLotacao; 

            this.evtTabLotacao.Id = this.id;
            this.evtTabLotacao.ideEvento = this.t_ideEvento;
            this.evtTabLotacao.ideEmpregador = this.t_ideEmpregador;
           this.evtTabLotacao.infoLotacao = this.infoLotacao;

            this.t_ideEmpregador.nrInsc = this.nrInsc;
            this.t_ideEmpregador.tpInsc = this.tpInsc;

           this.infoLotacao.inclusao = this.inclusao;

            this.inclusao.ideLotacao = this.ideLotacao;
            this.inclusao.dadosLotacao = this.dadosLotacao;

            this.ideLotacao.codLotacao = this.codLotacao;
            this.ideLotacao.fimValid = this.fimValid;
            this.ideLotacao.iniValid = this.iniValid;

            this.dadosLotacao.fpasLotacao = this.fpasLotacao;

            this.fpasLotacao.infoProcJudTerceiros = this.infoProcJudTerceiros;
            this.infoProcJudTerceiros[0] = new T_dadosLotacaoFpasLotacaoProcJudTerceiro();
            this.infoProcJudTerceiros[0].codTerc = this.codTerc;
            this.infoProcJudTerceiros[0].nrProcJud = this.nrProcJud;

            this.dadosLotacao.infoEmprParcial = this.infoEmprParcial;
            this.dadosLotacao.dadosOpPort = this.dadosOpPort;

            this.infoLotacao.alteracao = this.alteracao;

             this.alteracao.ideLotacao = this.ideLotacao;
            this.alteracao.dadosLotacao = this.dadosLotacao;
            this.alteracao.novaValidade = this.novaValidade; 

            this.infoLotacao.exclusao = this.exclusao;
            this.exclusao.ideLotacao = this.ideLotacao;

            XmlSerializer xml = new XmlSerializer(typeof(eSocialEvtTabLotacao));
            xml.Serialize(Console.Out, evtTabLotacao);
            Console.Read();

        }

    }
}
