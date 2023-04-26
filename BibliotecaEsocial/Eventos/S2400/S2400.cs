using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using BibliotecaEsocial.Model.S2400;

namespace BibliotecaEsocial.Eventos.S2400
{
    class S2400
    {
        private eSocialEvtCdBenefIn evtCdBenefIn = new eSocialEvtCdBenefIn();
        private T_ideEvento_trab_PJ t_ideEvento = new T_ideEvento_trab_PJ();
        private eSocialEvtCdBenefInIdeEmpregador t_ideEmpregador = new eSocialEvtCdBenefInIdeEmpregador();
        private eSocialEvtCdBenefInBeneficiario beneficiario = new eSocialEvtCdBenefInBeneficiario();
        private eSocialEvtCdBenefInBeneficiarioEndereco endereco = new eSocialEvtCdBenefInBeneficiarioEndereco();

        private eSocialEvtCdBenefInBeneficiarioDependente[] dependente =
            new eSocialEvtCdBenefInBeneficiarioDependente[1];

        private string id = string.Empty;
        private string nrInsc = string.Empty;
        private string cpfBenef = string.Empty;
        private sbyte tpInsc = 0;
        private object brasil = new object();
        private object exterior = new object();
        private string tpDep = string.Empty;
        private string nmDep = string.Empty;
        private DateTime dtNascto = DateTime.Now;

        public void s2400()
        {
            this.evtCdBenefIn.Id = this.id;
            this.evtCdBenefIn.ideEvento = this.t_ideEvento;
            this.evtCdBenefIn.ideEmpregador = this.t_ideEmpregador;
            this.evtCdBenefIn.beneficiario = this.beneficiario;

            this.t_ideEmpregador.nrInsc = this.nrInsc;
            this.t_ideEmpregador.tpInsc = this.tpInsc;

            this.beneficiario.endereco = this.endereco;
            this.beneficiario.cpfBenef = this.cpfBenef;

            this.endereco.brasil = this.brasil;
            this.endereco.exterior = this.exterior;

            this.beneficiario.dependente = this.dependente;
            this.dependente[0] = new eSocialEvtCdBenefInBeneficiarioDependente();
            this.dependente[0].tpDep = this.tpDep;
            this.dependente[0].nmDep = this.nmDep ;
            this.dependente[0].dtNascto = this.dtNascto;

            XmlSerializer xml = new XmlSerializer(typeof(eSocialEvtCdBenefIn));
            xml.Serialize(Console.Out, evtCdBenefIn);
            Console.Read();

        }
    }
}
