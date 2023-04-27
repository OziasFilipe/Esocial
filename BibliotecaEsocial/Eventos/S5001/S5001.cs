
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using BibliotecaEsocial.Model.S5001;

namespace BibliotecaEsocial.Eventos.S5001
{
    class S5001
    {
        private eSocialEvtBasesTrab evtBasesTrab = new eSocialEvtBasesTrab();
        private T_ideEmpregador t_ideEmpregador = new T_ideEmpregador();
        private T_ideEvento_retorno_trab t_ideEvento = new T_ideEvento_retorno_trab();
        private eSocialEvtBasesTrabIdeTrabalhador ideTrabalhador = new eSocialEvtBasesTrabIdeTrabalhador();
        private eSocialEvtBasesTrabIdeTrabalhadorInfoCompl infoCompl = new eSocialEvtBasesTrabIdeTrabalhadorInfoCompl();
        private T_sucessaoVinc sucessaoVinc = new T_sucessaoVinc();

        private eSocialEvtBasesTrabIdeTrabalhadorInfoComplInfoInterm[] infoInterm =
            new eSocialEvtBasesTrabIdeTrabalhadorInfoComplInfoInterm[1];

        private eSocialEvtBasesTrabIdeTrabalhadorInfoComplInfoComplCont[] infoComplCont =
            new eSocialEvtBasesTrabIdeTrabalhadorInfoComplInfoComplCont[1];

        private eSocialEvtBasesTrabIdeTrabalhadorProcJudTrab[] procJudTrab =
            new eSocialEvtBasesTrabIdeTrabalhadorProcJudTrab[1];

        private eSocialEvtBasesTrabInfoCpCalc[] infoCpCalc = new eSocialEvtBasesTrabInfoCpCalc[1];
        private eSocialEvtBasesTrabInfoCpCalcTpCR tpCr = new eSocialEvtBasesTrabInfoCpCalcTpCR();
        private eSocialEvtBasesTrabInfoCp infoCp = new eSocialEvtBasesTrabInfoCp();
        private eSocialEvtBasesTrabInfoCpIdeEstabLot[] ideEstabLot = new eSocialEvtBasesTrabInfoCpIdeEstabLot[1];

        private eSocialEvtBasesTrabInfoCpIdeEstabLotInfoCategIncid[] infoCategIncid =
            new eSocialEvtBasesTrabInfoCpIdeEstabLotInfoCategIncid[1];

        private eSocialEvtBasesTrabInfoCpIdeEstabLotInfoCategIncidInfoBaseCS[] infoBaseCs =
            new eSocialEvtBasesTrabInfoCpIdeEstabLotInfoCategIncidInfoBaseCS[1];

        private eSocialEvtBasesTrabInfoCpIdeEstabLotInfoCategIncidCalcTerc[] calcTerc =
            new eSocialEvtBasesTrabInfoCpIdeEstabLotInfoCategIncidCalcTerc[1];

        private eSocialEvtBasesTrabInfoCpIdeEstabLotInfoCategIncidInfoPerRef[] infoPerRef =
            new eSocialEvtBasesTrabInfoCpIdeEstabLotInfoCategIncidInfoPerRef[1];

        private eSocialEvtBasesTrabInfoCpIdeEstabLotInfoCategIncidCalcTercTpCR tpCr2 =
            new eSocialEvtBasesTrabInfoCpIdeEstabLotInfoCategIncidCalcTercTpCR();

        private eSocialEvtBasesTrabInfoCpIdeEstabLotInfoCategIncidInfoPerRefIdeADC[] ideAdc =
            new eSocialEvtBasesTrabInfoCpIdeEstabLotInfoCategIncidInfoPerRefIdeADC[1];

        private eSocialEvtBasesTrabInfoCpIdeEstabLotInfoCategIncidInfoPerRefDetInfoPerRef[] detInfoPerRef =
            new eSocialEvtBasesTrabInfoCpIdeEstabLotInfoCategIncidInfoPerRefDetInfoPerRef[1];


        private string id = string.Empty;
        private string nrInsc = string.Empty;
        private string cpfTrab = string.Empty;
        private string perApur = string.Empty;
        private sbyte tpInsc = 0;
        private sbyte indApuracao = 0;
        private sbyte dia = 0;
        private sbyte natAtividade = 0;
        private sbyte qtdDiasTrab = 0;
        private string codCBO = string.Empty;
        private string nrInscEstab = string.Empty;
        private string codLotacao = string.Empty;
        private string nrProcJud = string.Empty;
        private sbyte tpInscEstab = 0;
        private string matricula = string.Empty;
        private string codCateg = string.Empty;
        private sbyte indSimples = 0;
        private sbyte ind13 = 0;
        private sbyte tpValor = 0;
        private string perRef = string.Empty;
        private DateTime dtAcConv = DateTime.Now;
        private TS_tpAcConv tpAcConv = TS_tpAcConv.A;
        private sbyte ind132= 0;
        private sbyte tpVrPerRef = 0;

        public void s5001()
        {
            this.evtBasesTrab.Id = this.id;
            this.evtBasesTrab.ideEmpregador = this.t_ideEmpregador;
            this.evtBasesTrab.ideEvento = this.t_ideEvento;
            this.evtBasesTrab.ideTrabalhador = this.ideTrabalhador;

            this.t_ideEmpregador.nrInsc = this.nrInsc;
            this.t_ideEmpregador.tpInsc = this.tpInsc;

            this.t_ideEvento.indApuracao = this.indApuracao;
            this.t_ideEvento.perApur = this.perApur;

            this.ideTrabalhador.cpfTrab = this.cpfTrab;
            this.ideTrabalhador.infoCompl = this.infoCompl;

            this.infoCompl.sucessaoVinc = this.sucessaoVinc;
            this.infoCompl.infoInterm = this.infoInterm;
            this.infoCompl.infoComplCont = this.infoComplCont;

            this.infoComplCont[0] = new eSocialEvtBasesTrabIdeTrabalhadorInfoComplInfoComplCont();
            this.infoInterm[0] = new eSocialEvtBasesTrabIdeTrabalhadorInfoComplInfoInterm();

            this.infoInterm[0].dia = this.dia;

            this.infoComplCont[0].codCBO = this.codCBO;
            this.infoComplCont[0].natAtividade = this.natAtividade;
            this.infoComplCont[0].qtdDiasTrab = this.qtdDiasTrab;

            this.ideTrabalhador.procJudTrab = this.procJudTrab;

            this.procJudTrab[0] = new eSocialEvtBasesTrabIdeTrabalhadorProcJudTrab();
            this.procJudTrab[0].nrProcJud = this.nrProcJud;

            this.evtBasesTrab.infoCpCalc = this.infoCpCalc;
            
            this.infoCpCalc[0] = new eSocialEvtBasesTrabInfoCpCalc();
            this.infoCpCalc[0].tpCR = this.tpCr;

            this.evtBasesTrab.infoCp = this.infoCp;

            this.infoCp.ideEstabLot = this.ideEstabLot;

            this.ideEstabLot[0] = new eSocialEvtBasesTrabInfoCpIdeEstabLot();
            this.ideEstabLot[0].nrInsc = this.nrInscEstab;
            this.ideEstabLot[0].codLotacao = this.codLotacao;
            this.ideEstabLot[0].tpInsc = this.tpInscEstab;
            this.ideEstabLot[0].infoCategIncid = this.infoCategIncid;

            this.infoCategIncid[0] = new eSocialEvtBasesTrabInfoCpIdeEstabLotInfoCategIncid();
            this.infoCategIncid[0].matricula = this.matricula;
            this.infoCategIncid[0].codCateg = this.codCateg;
            this.infoCategIncid[0].indSimples = this.indSimples;
            this.infoCategIncid[0].infoBaseCS = this.infoBaseCs;

            this.infoBaseCs[0] = new eSocialEvtBasesTrabInfoCpIdeEstabLotInfoCategIncidInfoBaseCS();
            this.infoBaseCs[0].ind13 = this.ind13;
            this.infoBaseCs[0].tpValor = this.tpValor;

            this.infoCategIncid[0].calcTerc = this.calcTerc;
            this.infoCategIncid[0].infoPerRef = this.infoPerRef;

            this.calcTerc[0] = new eSocialEvtBasesTrabInfoCpIdeEstabLotInfoCategIncidCalcTerc();
            this.calcTerc[0].tpCR = this.tpCr2;

            this.infoPerRef[0] = new eSocialEvtBasesTrabInfoCpIdeEstabLotInfoCategIncidInfoPerRef();
            this.infoPerRef[0].perRef = this.perRef;
            this.infoPerRef[0].ideADC = this.ideAdc;

            this.ideAdc[0] = new eSocialEvtBasesTrabInfoCpIdeEstabLotInfoCategIncidInfoPerRefIdeADC();
            this.ideAdc[0].dtAcConv = this.dtAcConv;
            this.ideAdc[0].tpAcConv = this.tpAcConv;

            this.infoPerRef[0].detInfoPerRef = this.detInfoPerRef;
            this.detInfoPerRef[0] = new eSocialEvtBasesTrabInfoCpIdeEstabLotInfoCategIncidInfoPerRefDetInfoPerRef();

            this.detInfoPerRef[0].ind13 = this.ind132;
            this.detInfoPerRef[0].tpVrPerRef = this.tpVrPerRef;

            XmlSerializer xml = new XmlSerializer(typeof(eSocialEvtBasesTrab));
            xml.Serialize(Console.Out, evtBasesTrab);
            Console.Read();


        }
    }
}
