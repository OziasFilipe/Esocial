using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using BibliotecaEsocial.Model.S1000;

namespace BibliotecaEsocial.Eventos.S1000
{
    class S1000
    {
        private eSocial eSocialEvt = new eSocial();
        private eSocialEvtInfoEmpregador evtInfoEmpregador = new eSocialEvtInfoEmpregador();
        private eSocialEvtInfoEmpregadorIdeEmpregador t_ideEmpregador = new eSocialEvtInfoEmpregadorIdeEmpregador();
        private T_ideEvento_evtTab_inicial t_ideEvento = new T_ideEvento_evtTab_inicial();
        private eSocialEvtInfoEmpregadorInfoEmpregador infoEmpregador = new eSocialEvtInfoEmpregadorInfoEmpregador();

        private eSocialEvtInfoEmpregadorInfoEmpregadorAlteracao alteracao =
            new eSocialEvtInfoEmpregadorInfoEmpregadorAlteracao();

        private eSocialEvtInfoEmpregadorInfoEmpregadorExclusao exclusao =
            new eSocialEvtInfoEmpregadorInfoEmpregadorExclusao();

        private eSocialEvtInfoEmpregadorInfoEmpregadorInclusao inclusao =
            new eSocialEvtInfoEmpregadorInfoEmpregadorInclusao();

        private T_idePeriodo idePeriodo = new T_idePeriodo();
        private T_infoCadastro infoCadastro = new T_infoCadastro();
        private T_infoCadastroDadosIsencao dadosIsencao = new T_infoCadastroDadosIsencao();
        private T_infoCadastroInfoOrgInternacional infoOrgInternacional = new T_infoCadastroInfoOrgInternacional();
        private T_novaValidade novaValidade = new T_novaValidade();

        private string id = string.Empty;
        private string nrInsc = string.Empty;
        private sbyte tpInsc = 0;
        private string fimValid = string.Empty;
        private string iniValid = string.Empty;

        public void s1000()
        {
            this.eSocialEvt = this.eSocialEvt;
            this.eSocialEvt.evtInfoEmpregador = this.evtInfoEmpregador;
            this.evtInfoEmpregador.Id = this.id;
            this.evtInfoEmpregador.ideEmpregador = this.t_ideEmpregador;
            this.evtInfoEmpregador.ideEvento = this.t_ideEvento;
            this.evtInfoEmpregador.infoEmpregador = this.infoEmpregador;

            this.t_ideEmpregador.nrInsc = this.nrInsc;
            this.t_ideEmpregador.tpInsc = this.tpInsc;

            this.infoEmpregador.inclusao = this.inclusao;

            this.inclusao.idePeriodo = this.idePeriodo;
            this.inclusao.infoCadastro = this.infoCadastro;

            this.idePeriodo.fimValid = this.fimValid;
            this.idePeriodo.iniValid = this.iniValid;

             this.infoCadastro.dadosIsencao = this.dadosIsencao;
            this.infoCadastro.infoOrgInternacional = this.infoOrgInternacional;

            this.infoEmpregador.alteracao = this.alteracao;

            this.alteracao.idePeriodo = this.idePeriodo;
            this.alteracao.infoCadastro = this.infoCadastro;
            this.alteracao.novaValidade = this.novaValidade;

            this.infoEmpregador.exclusao = this.exclusao;
            this.exclusao.idePeriodo = this.idePeriodo;  

            XmlSerializer xml = new XmlSerializer(typeof(eSocial));
            xml.Serialize(Console.Out, eSocialEvt);
            Console.Read();
        }
    }
}
