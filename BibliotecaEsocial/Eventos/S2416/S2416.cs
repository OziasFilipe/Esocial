using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using BibliotecaEsocial.Model.S2416;

namespace BibliotecaEsocial.Eventos.S2416
{
    class S2416
    {
        private eSocialEvtCdBenAlt evtCdBenAlt = new eSocialEvtCdBenAlt();
        private T_ideEvento_trab_PJ t_ideEvento = new T_ideEvento_trab_PJ();
        private T_ideEmpregador_cnpj t_ideEmpregador = new T_ideEmpregador_cnpj();
        private T_ideBeneficio ideBeneficio = new T_ideBeneficio();
        private eSocialEvtCdBenAltInfoBenAlteracao infoBenAlteracao = new eSocialEvtCdBenAltInfoBenAlteracao();

        private eSocialEvtCdBenAltInfoBenAlteracaoDadosBeneficio dadosBeneficio =
            new eSocialEvtCdBenAltInfoBenAlteracaoDadosBeneficio();

        private eSocialEvtCdBenAltInfoBenAlteracaoDadosBeneficioInfoPenMorte infoPenMorte =
            new eSocialEvtCdBenAltInfoBenAlteracaoDadosBeneficioInfoPenMorte();

        private eSocialEvtCdBenAltInfoBenAlteracaoDadosBeneficioSuspensao suspensao =
            new eSocialEvtCdBenAltInfoBenAlteracaoDadosBeneficioSuspensao();


        private string id = string.Empty;
        private string nrInsc = string.Empty;
        private string cpfBenef = string.Empty;
        private string nrBeneficio = string.Empty;
        private sbyte tpInsc = 0;
        private DateTime dtAltBeneficio = DateTime.Now;

        public void s2416()
        {
            this.evtCdBenAlt.Id = this.id;
            this.evtCdBenAlt.ideEvento = this.t_ideEvento;
            this.evtCdBenAlt.ideEmpregador = this.t_ideEmpregador;
            this.evtCdBenAlt.ideBeneficio = this.ideBeneficio;
            this.evtCdBenAlt.infoBenAlteracao = this.infoBenAlteracao;


            this.ideBeneficio.cpfBenef = this.cpfBenef;
            this.ideBeneficio.nrBeneficio = this.nrBeneficio;


            this.t_ideEmpregador.nrInsc = this.nrInsc;
            this.t_ideEmpregador.tpInsc = this.tpInsc;

            this.infoBenAlteracao.dtAltBeneficio = this.dtAltBeneficio;
            this.infoBenAlteracao.dadosBeneficio = this.dadosBeneficio;

            this.dadosBeneficio.infoPenMorte = this.infoPenMorte;
            this.dadosBeneficio.suspensao = this.suspensao;

            XmlSerializer xml = new XmlSerializer(typeof(eSocialEvtCdBenAlt));
            xml.Serialize(Console.Out, evtCdBenAlt);
            Console.ReadLine();
        }
    }
}
