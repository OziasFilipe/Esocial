using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using BibliotecaEsocial.Model.S2420;

namespace BibliotecaEsocial.Eventos.S2420
{
    class S2420
    {
        private eSocialEvtCdBenTerm evtCdBenTerm = new eSocialEvtCdBenTerm();
        private T_ideEvento_trab_PJ t_ideEvento = new T_ideEvento_trab_PJ();
        private T_ideEmpregador_cnpj t_ideEmpregador = new T_ideEmpregador_cnpj();
        private T_ideBeneficio t_ideBeneficio = new T_ideBeneficio();
        private eSocialEvtCdBenTermInfoBenTermino infoBenTermino = new eSocialEvtCdBenTermInfoBenTermino();

        private string id = string.Empty;
        private string nrInsc = string.Empty;
        private string cpfBenef = string.Empty;
        private string nrBeneficio = string.Empty;
        private sbyte tpInsc = 0;
        private DateTime dtTermBeneficio = DateTime.Now;

        public void s2420()
        {
            this.evtCdBenTerm.Id = this.id;
            this.evtCdBenTerm.ideEvento = this.t_ideEvento;
            this.evtCdBenTerm.ideEmpregador = this.t_ideEmpregador;
            this.evtCdBenTerm.ideBeneficio = this.t_ideBeneficio;
            this.evtCdBenTerm.infoBenTermino = this.infoBenTermino;

            this.t_ideEmpregador.nrInsc = this.nrInsc;
            this.t_ideEmpregador.tpInsc = this.tpInsc;

            this.t_ideBeneficio.cpfBenef = this.cpfBenef;
            this.t_ideBeneficio.nrBeneficio = this.nrBeneficio;

            this.infoBenTermino.dtTermBeneficio = this.dtTermBeneficio;

            XmlSerializer xml = new XmlSerializer(typeof(eSocialEvtCdBenTerm));
            xml.Serialize(Console.Out, evtCdBenTerm);
            Console.Read();
        }
    }
}
