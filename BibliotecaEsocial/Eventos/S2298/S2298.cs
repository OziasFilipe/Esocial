using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using BibliotecaEsocial.Model.S2298;

namespace BibliotecaEsocial.Eventos.S2298
{
    class S2298
    {
        private eSocialEvtReintegr evtReintegr = new eSocialEvtReintegr();
        private T_ideEmpregador t_ideEmpregador = new T_ideEmpregador();
        private T_ideEvento_trab t_ideEvento = new T_ideEvento_trab();
        private T_ideVinculo t_ideVinculo = new T_ideVinculo();
        private eSocialEvtReintegrInfoReintegr infoReintegr = new eSocialEvtReintegrInfoReintegr();


        private string id = string.Empty;
        private string nrInsc = string.Empty;
        private sbyte tpInsc = 0;
        private string matricula = string.Empty;
        private string cpfTrab = string.Empty;
        private DateTime dtEfetRetorno = DateTime.Now;
        public void s2298()
        {
            this.evtReintegr.Id = this.id;
            this.evtReintegr.ideEmpregador = this.t_ideEmpregador;
            this.evtReintegr.ideEvento = this.t_ideEvento;
            this.evtReintegr.ideVinculo = this.t_ideVinculo;
            this.evtReintegr.infoReintegr = this.infoReintegr;


            this.t_ideEmpregador.nrInsc = this.nrInsc;
            this.t_ideEmpregador.tpInsc = this.tpInsc;

            this.t_ideVinculo.matricula = this.matricula;
            this.t_ideVinculo.cpfTrab = this.cpfTrab;

            this.infoReintegr.dtEfetRetorno = this.dtEfetRetorno;

            XmlSerializer xml = new XmlSerializer(typeof(eSocialEvtReintegr));
            xml.Serialize(Console.Out, evtReintegr);
            Console.ReadLine();
        }
    }
}
