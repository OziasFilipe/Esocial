using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using BibliotecaEsocial.Model.S1070;

namespace BibliotecaEsocial.Eventos.S1070
{
    class S1070
    {
        private eSocialEvtTabProcesso evtTabProcesso = new eSocialEvtTabProcesso();
        private T_ideEvento_evtTab t_ideEvento = new T_ideEvento_evtTab();
        private T_ideEmpregador t_ideEmpregador = new T_ideEmpregador();
        private eSocialEvtTabProcessoInfoProcesso infoProcesso = new eSocialEvtTabProcessoInfoProcesso();
        private eSocialEvtTabProcessoInfoProcessoAlteracao alteracao = new eSocialEvtTabProcessoInfoProcessoAlteracao();
        private eSocialEvtTabProcessoInfoProcessoExclusao exclusao = new eSocialEvtTabProcessoInfoProcessoExclusao();
        private eSocialEvtTabProcessoInfoProcessoInclusao inclusao = new eSocialEvtTabProcessoInfoProcessoInclusao();
        private T_ideProcesso ideProcesso = new T_ideProcesso();
        private T_dadosProc dadosProc = new T_dadosProc();
        private T_dadosProcDadosProcJud dadosProcJud = new T_dadosProcDadosProcJud();
        private T_novaValidade novaValidade = new T_novaValidade();
        private T_dadosProcInfoSusp[] infoSusp = new T_dadosProcInfoSusp[1];

        private string id = string.Empty;
        private string nrInsc = string.Empty;
        private string nrInscProc = string.Empty;
        private string iniValid = string.Empty;
        private string fimValid = string.Empty;
        private sbyte tpInsc = 0;
        private sbyte tpProc = 0;

        public void s1070()
        {
            this.evtTabProcesso.Id = this.id;
            this.evtTabProcesso.ideEvento = this.t_ideEvento;
            this.evtTabProcesso.ideEmpregador = this.t_ideEmpregador;
            this.evtTabProcesso.infoProcesso = this.infoProcesso;

            this.t_ideEmpregador.nrInsc = this.nrInsc;
            this.t_ideEmpregador.tpInsc = this.tpInsc;

            this.infoProcesso.inclusao = this.inclusao;

            this.inclusao.ideProcesso = this.ideProcesso;
            this.inclusao.dadosProc = this.dadosProc;

            this.ideProcesso.nrProc = this.nrInscProc;
            this.ideProcesso.iniValid = this.iniValid;
            this.ideProcesso.fimValid = this.fimValid;
            this.ideProcesso.tpProc = this.tpProc;

            this.dadosProc.dadosProcJud = this.dadosProcJud;
            this.dadosProc.infoSusp = this.infoSusp;

            this.infoProcesso.alteracao = this.alteracao;

            this.alteracao.ideProcesso = this.ideProcesso;
            this.alteracao.dadosProc = this.dadosProc;
            this.alteracao.novaValidade = this.novaValidade;

            this.infoProcesso.exclusao = this.exclusao;

            this.exclusao.ideProcesso = this.ideProcesso;

            XmlSerializer xml = new XmlSerializer(typeof(eSocialEvtTabProcesso));
            xml.Serialize(Console.Out, evtTabProcesso);
            Console.Read();
        }
    }
}
