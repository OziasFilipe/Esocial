using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using BibliotecaEsocial.Model.S2220;

namespace BibliotecaEsocial.Eventos.S2220
{
    class S2220
    {
        private eSocialEvtMonit evtMonit = new eSocialEvtMonit();
        private T_ideEvento_trab t_ideEvento = new T_ideEvento_trab();
        private T_ideEmpregador t_ideEmpregador = new T_ideEmpregador();
        private T_ideVinculo_sst t_ideVinculo = new T_ideVinculo_sst();
        private eSocialEvtMonitExMedOcup exMedOcup = new eSocialEvtMonitExMedOcup();
        private eSocialEvtMonitExMedOcupAso aso = new eSocialEvtMonitExMedOcupAso();
        private eSocialEvtMonitExMedOcupAsoExame[] exame = new eSocialEvtMonitExMedOcupAsoExame[1];
        private eSocialEvtMonitExMedOcupAsoMedico medico = new eSocialEvtMonitExMedOcupAsoMedico();
        private eSocialEvtMonitExMedOcupRespMonit respMonit = new eSocialEvtMonitExMedOcupRespMonit();
       
        private string nrInsc = string.Empty;
        private sbyte tpInsc = 0;
        private string matricula = string.Empty;
        private string codCateg = string.Empty;
        private string cpfTrab = string.Empty;
        private sbyte tpExameOcup = 0;
        private DateTime dtAso = DateTime.Now;
        private DateTime dtExm = DateTime.Now;
        private string procRealizado = string.Empty;

        public void s2220()
        {

            this.evtMonit.ideEvento = this.t_ideEvento;
            this.evtMonit.ideEmpregador = this.t_ideEmpregador;
            this.evtMonit.ideVinculo = this.t_ideVinculo;
            this.evtMonit.exMedOcup = this.exMedOcup;

            this.t_ideEmpregador.nrInsc = this.nrInsc;
            this.t_ideEmpregador.tpInsc = this.tpInsc;

            this.t_ideVinculo.matricula = this.matricula;
            this.t_ideVinculo.codCateg = this.codCateg;
            this.t_ideVinculo.cpfTrab = this.cpfTrab;

            this.exMedOcup.tpExameOcup = this.tpExameOcup;
            this.exMedOcup.aso = this.aso;

            this.aso.dtAso = this.dtAso;

            this.aso.exame = this.exame;
            this.exame[0] = new eSocialEvtMonitExMedOcupAsoExame();
            this.exame[0].dtExm = this.dtExm;
            this.exame[0].procRealizado = this.procRealizado;
            
            this.aso.medico = this.medico;
            
            this.exMedOcup.respMonit = this.respMonit;

            XmlSerializer xml = new XmlSerializer(typeof(eSocialEvtMonit));
            xml.Serialize(Console.Out, evtMonit);
            Console.ReadLine();

        }
    }
}
