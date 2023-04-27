using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BibliotecaEsocial.Model.S2231;
using System.Xml.Serialization;
using BibliotecaEsocial.Model.S2240;

namespace BibliotecaEsocial.Eventos.S2240
{
    class S2240
    {
        private eSocialEvtExpRisco evtExpRisco = new eSocialEvtExpRisco();
        private T_ideEmpregador t_ideEmpregador = new T_ideEmpregador();
        private T_ideEvento_trab t_ideEvento = new T_ideEvento_trab();
        private T_ideVinculo_sst t_ideVinculo = new T_ideVinculo_sst();
        private eSocialEvtExpRiscoInfoExpRisco infoExpRisco = new eSocialEvtExpRiscoInfoExpRisco();
        private eSocialEvtExpRiscoInfoExpRiscoInfoAmb[] infoAmb = new eSocialEvtExpRiscoInfoExpRiscoInfoAmb[1];
        private eSocialEvtExpRiscoInfoExpRiscoInfoAtiv infoAtiv = new eSocialEvtExpRiscoInfoExpRiscoInfoAtiv();
        private eSocialEvtExpRiscoInfoExpRiscoAgNoc[] agNoc = new eSocialEvtExpRiscoInfoExpRiscoAgNoc[1];
        private eSocialEvtExpRiscoInfoExpRiscoAgNocEpcEpi epcEpi = new eSocialEvtExpRiscoInfoExpRiscoAgNocEpcEpi();

        private eSocialEvtExpRiscoInfoExpRiscoAgNocEpcEpiEpiCompl epiCompl =
            new eSocialEvtExpRiscoInfoExpRiscoAgNocEpcEpiEpiCompl();

        private eSocialEvtExpRiscoInfoExpRiscoAgNocEpcEpiEpi[]
            epi = new eSocialEvtExpRiscoInfoExpRiscoAgNocEpcEpiEpi[1];

        private eSocialEvtExpRiscoInfoExpRiscoRespReg[] respReg = new eSocialEvtExpRiscoInfoExpRiscoRespReg[1];
        private eSocialEvtExpRiscoInfoExpRiscoObs obs = new eSocialEvtExpRiscoInfoExpRiscoObs();

        private string id = string.Empty;
        private string nrInsc = string.Empty;
        private sbyte tpInsc = 0;
        private string matricula = string.Empty;
        private string codCateg = string.Empty;
        private string cpfTrab = string.Empty;
        private DateTime dtIniCondicao = DateTime.Now;
        private string t_nrInsc = string.Empty;
        private sbyte t_tpInsc = 0;
        private string codAgNoc = string.Empty;
        private string dscAgNoc = string.Empty;
        private string docAval = string.Empty;
        private string cpfResp = string.Empty;

        public void s2240()
        {
            this.evtExpRisco.Id = this.id;
            this.evtExpRisco.ideEmpregador = this.t_ideEmpregador;
            this.evtExpRisco.ideEvento = this.t_ideEvento;
            this.evtExpRisco.ideVinculo = this.t_ideVinculo;
            this.evtExpRisco.infoExpRisco = this.infoExpRisco;

            this.t_ideEmpregador.nrInsc = this.nrInsc;
            this.t_ideEmpregador.tpInsc = this.tpInsc;

            this.t_ideVinculo.matricula = this.matricula;
            this.t_ideVinculo.cpfTrab = this.cpfTrab;
            this.t_ideVinculo.codCateg = this.codCateg;

            this.infoExpRisco.dtIniCondicao = this.dtIniCondicao;
            this.infoExpRisco.infoAmb = this.infoAmb;

            this.infoAmb[0] = new eSocialEvtExpRiscoInfoExpRiscoInfoAmb();
            this.infoAmb[0].tpInsc = this.t_tpInsc;
            this.infoAmb[0].nrInsc = this.t_nrInsc;

            this.infoExpRisco.infoAtiv = this.infoAtiv;
            this.infoExpRisco.agNoc = this.agNoc;

            this.agNoc[0] = new eSocialEvtExpRiscoInfoExpRiscoAgNoc();
            this.agNoc[0].codAgNoc = this.codAgNoc;
            this.agNoc[0].dscAgNoc = this.dscAgNoc;
            this.agNoc[0].epcEpi = this.epcEpi;

            this.epcEpi.epi = this.epi;
            this.epi[0] = new eSocialEvtExpRiscoInfoExpRiscoAgNocEpcEpiEpi();

            this.epi[0].docAval = this.docAval;
            this.epcEpi.epiCompl = this.epiCompl;

            this.infoExpRisco.respReg = this.respReg;

            this.respReg[0] = new eSocialEvtExpRiscoInfoExpRiscoRespReg();
            this.respReg[0].cpfResp = this.cpfResp;

            this.infoExpRisco.obs = this.obs;

            XmlSerializer xml = new XmlSerializer(typeof(eSocialEvtExpRisco));
            xml.Serialize(Console.Out, evtExpRisco);
            Console.ReadLine();
        }
    }
}
