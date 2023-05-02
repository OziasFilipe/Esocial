using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using BibliotecaEsocial.Model.S1298;

namespace BibliotecaEsocial.Eventos.S1298
{
    class S1298
    {
        private eSocial eSocialEvt = new eSocial();
        private eSocialEvtReabreEvPer evtReabreEvPer = new eSocialEvtReabreEvPer();
        private T_ideEvento_folha_sem_retificacao t_ideEvento = new T_ideEvento_folha_sem_retificacao();
        private T_ideEmpregador t_ideEmpregador = new T_ideEmpregador();

        private string id = string.Empty;
        private string perApur = string.Empty;
        private string nrInsc = string.Empty;
        private sbyte indGuia = 0;
        private sbyte tpInsc = 0;
        private sbyte indApuracao = 0;
        public void s1298()
        {
            this.eSocialEvt = this.eSocialEvt;
            this.eSocialEvt.evtReabreEvPer = this.evtReabreEvPer;

            this.evtReabreEvPer.Id = this.id;
            this.evtReabreEvPer.ideEvento = this.t_ideEvento;
            this.evtReabreEvPer.ideEmpregador = this.t_ideEmpregador;

            this.t_ideEvento.perApur = this.perApur;
            this.t_ideEvento.indGuia = this.indGuia;
            this.t_ideEvento.indApuracao = this.indApuracao;

            this.t_ideEmpregador.nrInsc = this.nrInsc;
            this.t_ideEmpregador.tpInsc = this.tpInsc;

            XmlSerializer xml = new XmlSerializer(typeof(eSocial));
            xml.Serialize(Console.Out, eSocialEvt);
            Console.Read();
        }
    }
}
