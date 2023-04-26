using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using BibliotecaEsocial.Model.S2405;

namespace BibliotecaEsocial.Eventos.S2405
{
    class S2405
    {

        private eSocialEvtCdBenefAlt evtCdBenefAlt = new eSocialEvtCdBenefAlt();
        private T_ideEmpregador_cnpj t_ideEmpregador = new T_ideEmpregador_cnpj();
        private T_ideEvento_trab_PJ t_ideEvento = new T_ideEvento_trab_PJ();
        private eSocialEvtCdBenefAltIdeBenef ideBenef = new eSocialEvtCdBenefAltIdeBenef();
        private eSocialEvtCdBenefAltAlteracao alteracao = new eSocialEvtCdBenefAltAlteracao();
        private eSocialEvtCdBenefAltAlteracaoDadosBenef dadosBenef = new eSocialEvtCdBenefAltAlteracaoDadosBenef();

        private eSocialEvtCdBenefAltAlteracaoDadosBenefEndereco endereco = new eSocialEvtCdBenefAltAlteracaoDadosBenefEndereco();

        private eSocialEvtCdBenefAltAlteracaoDadosBenefDependente[] dependente =
            new eSocialEvtCdBenefAltAlteracaoDadosBenefDependente[1];

        private string id = string.Empty;
        private string nrInsc = string.Empty;
        private string cpfBenef = string.Empty;
        private sbyte tpInsc = 0;
        private DateTime dtAlteracao = DateTime.Now;
        private object brasil = new object();
        private object exterior = new object();
        private string tpDep = string.Empty;
        private string nmDep = string.Empty;
        private DateTime dtNascto = DateTime.Now;
        public void s2405()
        {
            this.evtCdBenefAlt.Id = this.id;
            this.evtCdBenefAlt.ideEmpregador = this.t_ideEmpregador;
            this.evtCdBenefAlt.ideEvento = this.t_ideEvento;
            this.evtCdBenefAlt.ideBenef = this.ideBenef;

            this.ideBenef.cpfBenef = this.cpfBenef;

            this.t_ideEmpregador.nrInsc = this.nrInsc;
            this.t_ideEmpregador.tpInsc = this.tpInsc;

            this.evtCdBenefAlt.alteracao = this.alteracao;
            this.alteracao.dtAlteracao = this.dtAlteracao;
            this.alteracao.dadosBenef = this.dadosBenef;

            this.dadosBenef.endereco = this.endereco;

           this.endereco.brasil = this.brasil;
            this.endereco.exterior = this.exterior;


            this.dadosBenef.dependente = this.dependente;
            this.dependente[0] = new eSocialEvtCdBenefAltAlteracaoDadosBenefDependente();
            this.dependente[0].tpDep = this.tpDep;
            this.dependente[0].nmDep = this.nmDep;
            this.dependente[0].dtNascto = this.dtNascto;

            XmlSerializer xml = new XmlSerializer(typeof(eSocialEvtCdBenefAlt));
            xml.Serialize(Console.Out, evtCdBenefAlt);
            Console.Read();
            

        }
    }
}
