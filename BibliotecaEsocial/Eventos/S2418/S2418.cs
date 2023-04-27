using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using BibliotecaEsocial.Model.S2418;

namespace BibliotecaEsocial.Eventos.S2418
{
    class S2418
    {
        private eSocialEvtReativBen evtReativBen = new eSocialEvtReativBen();
        private T_ideEvento_trab_PJ t_ideEvento = new T_ideEvento_trab_PJ();
        private T_ideEmpregador_cnpj t_ideEmpregador = new T_ideEmpregador_cnpj();
        private T_ideBeneficio t_ideBeneficio = new T_ideBeneficio();
        private eSocialEvtReativBenInfoReativ infoReativ = new eSocialEvtReativBenInfoReativ();

        private string id = string.Empty;
        private string nrInsc = string.Empty;
        private string cpfBenef = string.Empty;
        private string nrBeneficio = string.Empty;
        private sbyte tpInsc = 0;
        private DateTime dtEfetReativ = DateTime.Now;

        public void s2418()
        {
            this.evtReativBen.Id = this.id;
            this.evtReativBen.ideEvento = this.t_ideEvento;
            this.evtReativBen.ideEmpregador = this.t_ideEmpregador;
            this.evtReativBen.ideBeneficio = this.t_ideBeneficio;
            this.evtReativBen.infoReativ = this.infoReativ;

            this.t_ideEmpregador.nrInsc = this.nrInsc;
            this.t_ideEmpregador.tpInsc = this.tpInsc;

            this.t_ideBeneficio.cpfBenef = this.cpfBenef;
            this.t_ideBeneficio.nrBeneficio = this.nrBeneficio;

            this.infoReativ.dtEfetReativ = this.dtEfetReativ;

            XmlSerializer xml = new XmlSerializer(typeof(eSocialEvtReativBen));
            xml.Serialize(Console.Out, evtReativBen);
            Console.Read();

        }
    }
}