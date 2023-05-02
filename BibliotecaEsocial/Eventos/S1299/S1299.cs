using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using BibliotecaEsocial.Model.S1299;

namespace BibliotecaEsocial.Eventos.S1299
{
    class S1299
    {
        private eSocial eSocialEvt = new eSocial();
        private eSocialEvtFechaEvPer evtFechaEvPer = new eSocialEvtFechaEvPer();
        private T_ideEvento_folha_sem_retificacao t_ideEvento = new T_ideEvento_folha_sem_retificacao();
        private T_ideEmpregador t_ideEmpregador = new T_ideEmpregador();
        private eSocialEvtFechaEvPerInfoFech infoFech = new eSocialEvtFechaEvPerInfoFech();

        private string id = string.Empty;
        private string perApur = string.Empty;
        private string nrInsc = string.Empty;
        private sbyte indGuia = 0;
        private sbyte tpInsc = 0;
        private sbyte indApuracao = 0;
        public void s1299()
        {

            this.eSocialEvt = this.eSocialEvt;
            this.eSocialEvt.evtFechaEvPer = this.evtFechaEvPer;

            this.evtFechaEvPer.Id = this.id;
            this.evtFechaEvPer.ideEvento = this.t_ideEvento;
            this.evtFechaEvPer.ideEmpregador = this.t_ideEmpregador;
            this.evtFechaEvPer.infoFech = this.infoFech;

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
