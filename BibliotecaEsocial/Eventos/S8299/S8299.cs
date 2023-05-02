using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using BibliotecaEsocial.Model.S8299;

namespace BibliotecaEsocial.Eventos.S8299
{
    class S8299
    {
        private eSocial eSocialEvt = new eSocial();
        private eSocialEvtBaixa evtBaixa = new eSocialEvtBaixa();
        private T_ideEvento_trab_jud t_ideEvento = new T_ideEvento_trab_jud();
        private T_ideEmpregador t_ideEmpregador = new T_ideEmpregador();
        private T_ideVinculo_baixa ideVinculo = new T_ideVinculo_baixa();
        private eSocialEvtBaixaInfoBaixa infoBaixa = new eSocialEvtBaixaInfoBaixa();

        private string id = string.Empty;
        private string nrInsc = string.Empty;
        private sbyte tpInsc = 0;
        private string cpfTrab = string.Empty;
        private string matricula = string.Empty;
        private DateTime dtDeslig = DateTime.Now;

        public void s8299()
        {
            this.eSocialEvt = this.eSocialEvt;
            this.eSocialEvt.evtBaixa = this.evtBaixa;

            this.evtBaixa.Id = this.id;
            this.evtBaixa.ideEvento = this.t_ideEvento;
            this.evtBaixa.ideEmpregador = this.t_ideEmpregador;
            this.evtBaixa.ideVinculo = this.ideVinculo;
            this.evtBaixa.infoBaixa = this.infoBaixa;

            this.t_ideEmpregador.nrInsc = this.nrInsc;
            this.t_ideEmpregador.tpInsc = this.tpInsc;

            this.ideVinculo.cpfTrab = this.cpfTrab;
            this.ideVinculo.matricula = this.matricula;

            this.infoBaixa.dtDeslig = this.dtDeslig;

            XmlSerializer xml = new XmlSerializer(typeof(eSocial));
            xml.Serialize(Console.Out, eSocialEvt);
            Console.Read();

        }
    }
}
