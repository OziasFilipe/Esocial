using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using BibliotecaEsocial.ClassesEsquemas.S2410;

namespace BibliotecaEsocial.Eventos.S2410
{
    class S2410
    {
        private eSocialEvtCdBenIn evtCdBenIn = new eSocialEvtCdBenIn();
        private T_ideEvento_trab_PJ t_ideEvento = new T_ideEvento_trab_PJ();
        private T_ideEmpregador_cnpj t_ideEmpregador = new T_ideEmpregador_cnpj();
        private eSocialEvtCdBenInBeneficiario beneficiario = new eSocialEvtCdBenInBeneficiario();
        private eSocialEvtCdBenInInfoBenInicio infoBenInicio = new eSocialEvtCdBenInInfoBenInicio();

        private eSocialEvtCdBenInInfoBenInicioDadosBeneficio dadosBeneficio =
            new eSocialEvtCdBenInInfoBenInicioDadosBeneficio();

        private eSocialEvtCdBenInInfoBenInicioDadosBeneficioInfoPenMorte infoPenMorte =
            new eSocialEvtCdBenInInfoBenInicioDadosBeneficioInfoPenMorte();

        private eSocialEvtCdBenInInfoBenInicioDadosBeneficioInfoPenMorteInstPenMorte instPenMorte =
            new eSocialEvtCdBenInInfoBenInicioDadosBeneficioInfoPenMorteInstPenMorte();

        private eSocialEvtCdBenInInfoBenInicioSucessaoBenef sucessaoBenef =
            new eSocialEvtCdBenInInfoBenInicioSucessaoBenef();

        private eSocialEvtCdBenInInfoBenInicioMudancaCPF mudancaCpf = new eSocialEvtCdBenInInfoBenInicioMudancaCPF();

        private eSocialEvtCdBenInInfoBenInicioInfoBenTermino infoBenTermino =
            new eSocialEvtCdBenInInfoBenInicioInfoBenTermino();

        private string id = string.Empty;
        private string nrInsc = string.Empty;
        private string cpfBenef = string.Empty;
        private string nrBeneficio = string.Empty;
        private sbyte tpInsc = 0;
        public void s2410()
        {
            this.evtCdBenIn.Id = this.id;
            this.evtCdBenIn.ideEvento = this.t_ideEvento;
            this.evtCdBenIn.ideEmpregador = this.t_ideEmpregador;
            this.evtCdBenIn.beneficiario = this.beneficiario;
            this.evtCdBenIn.infoBenInicio = this.infoBenInicio;

            this.t_ideEmpregador.nrInsc = this.nrInsc;
            this.t_ideEmpregador.tpInsc = this.tpInsc;

            this.beneficiario.cpfBenef = this.cpfBenef;

            this.infoBenInicio.nrBeneficio = this.nrBeneficio;
            this.infoBenInicio.dadosBeneficio = this.dadosBeneficio;

            this.dadosBeneficio.infoPenMorte = this.infoPenMorte;

            this.infoPenMorte.instPenMorte = this.instPenMorte;
            this.infoBenInicio.sucessaoBenef = this.sucessaoBenef;
            this.infoBenInicio.mudancaCPF = this.mudancaCpf;
            this.infoBenInicio.infoBenTermino = this.infoBenTermino;

            XmlSerializer xml = new XmlSerializer(typeof(eSocialEvtCdBenIn));
            xml.Serialize(Console.Out, evtCdBenIn);
            Console.Read();

        }
    }
}
