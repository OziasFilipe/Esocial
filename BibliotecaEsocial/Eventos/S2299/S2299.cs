using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using BibliotecaEsocial.Model.S2299;

namespace BibliotecaEsocial.Eventos.S2299
{
    class S2299
    {
        private eSocial eSocialEvt = new eSocial();
        private eSocialEvtDeslig evtDeslig = new eSocialEvtDeslig();
        private T_ideEvento_trab_indGuia t_ideEvento = new T_ideEvento_trab_indGuia();
        private T_ideEmpregador t_ideEmpregador = new T_ideEmpregador();
        private T_ideVinculo t_ideVinculo = new T_ideVinculo();
        private eSocialEvtDesligInfoDeslig infoDeslig = new eSocialEvtDesligInfoDeslig();
        private T_infoInterm[] infoInterm = new T_infoInterm[1];
        private eSocialEvtDesligInfoDesligObservacoes[] observacoes = new eSocialEvtDesligInfoDesligObservacoes[1];
        private eSocialEvtDesligInfoDesligSucessaoVinc sucessaoVinc = new eSocialEvtDesligInfoDesligSucessaoVinc();
        private eSocialEvtDesligInfoDesligTransfTit transfTit = new eSocialEvtDesligInfoDesligTransfTit();
        private eSocialEvtDesligInfoDesligMudancaCPF mudancaCpf = new eSocialEvtDesligInfoDesligMudancaCPF();
        private eSocialEvtDesligInfoDesligVerbasResc verbasResc = new eSocialEvtDesligInfoDesligVerbasResc();
        private eSocialEvtDesligInfoDesligVerbasRescDmDev[] dmDev = new eSocialEvtDesligInfoDesligVerbasRescDmDev[1];
        private T_infoRRA infoRrra = new T_infoRRA();
        private T_infoRRADespProcJud despProcJud = new T_infoRRADespProcJud();
        private T_infoRRAIdeAdv[] ideAdv = new T_infoRRAIdeAdv[1];
        private T_ideEstabLot[] infoPerApur = new T_ideEstabLot[1];
        private T_ideEstabLotDetVerbas[] detVerbas = new T_ideEstabLotDetVerbas[1];
        private T_ideEstabLotInfoAgNocivo infoAgNocivo = new T_ideEstabLotInfoAgNocivo();
        private T_infoSimples infoSimples = new T_infoSimples();

        private eSocialEvtDesligInfoDesligVerbasRescDmDevIdeADC[] infoPerAnt =
            new eSocialEvtDesligInfoDesligVerbasRescDmDevIdeADC[1];

        private string id = string.Empty;
        private string nrInsc = string.Empty;
        private sbyte tpInsc = 0;
        private string cpfTrab = string.Empty;
        private string matricula = string.Empty;
        private DateTime dtDeslig = DateTime.Now;
        private sbyte dia = 0;
        private string ideDmDev = string.Empty;
        private string nrInsc2 = string.Empty;
        private sbyte tpInsc2 = 0;
        private string nrInsc3 = string.Empty;
        private sbyte tpInsc3 = 0;
        private string codLotacao = string.Empty;


        public void s2299()
        {
            this.eSocialEvt = this.eSocialEvt;
            this.eSocialEvt.evtDeslig = this.evtDeslig;

            this.evtDeslig.Id = this.id;
            this.evtDeslig.ideEvento = this.t_ideEvento;
            this.evtDeslig.ideEmpregador = this.t_ideEmpregador;
            this.evtDeslig.ideVinculo = this.t_ideVinculo;
            this.evtDeslig.infoDeslig = this.infoDeslig;

            this.t_ideEmpregador.nrInsc = this.nrInsc;
            this.t_ideEmpregador.tpInsc = this.tpInsc;

            this.t_ideVinculo.cpfTrab = this.cpfTrab;
            this.t_ideVinculo.matricula = this.matricula;

            this.infoDeslig.dtDeslig = this.dtDeslig;
            this.infoDeslig.infoInterm = this.infoInterm;

            this.infoInterm[0] = new T_infoInterm();
            this.infoInterm[0].dia = this.dia;

            this.infoDeslig.observacoes = this.observacoes;
            this.infoDeslig.sucessaoVinc = this.sucessaoVinc;
            this.infoDeslig.transfTit = this.transfTit;
            this.infoDeslig.mudancaCPF = this.mudancaCpf;
            this.infoDeslig.verbasResc = this.verbasResc;

            this.verbasResc.dmDev = this.dmDev;

            //this.dmDev[0].ideDmDev = this.ideDmDev;
            this.dmDev[0].infoRRA = this.infoRrra;

            this.infoRrra.despProcJud = this.despProcJud;
            this.infoRrra.ideAdv = this.ideAdv;

            this.ideAdv[0] = new T_infoRRAIdeAdv();
            this.ideAdv[0].nrInsc = this.nrInsc2;
            this.ideAdv[0].tpInsc = this.tpInsc2;

            this.dmDev[0].infoPerApur = this.infoPerApur;

            this.infoPerApur[0] = new T_ideEstabLot();
            this.infoPerApur[0].nrInsc = this.nrInsc3;
            this.infoPerApur[0].tpInsc = this.tpInsc3;
            this.infoPerApur[0].codLotacao = this.codLotacao;
            this.infoPerApur[0].detVerbas = this.detVerbas;
            this.infoPerApur[0].infoAgNocivo = this.infoAgNocivo;
            this.infoPerApur[0].infoSimples = this.infoSimples;

            this.dmDev[0].infoPerAnt = this.infoPerAnt;

            this.infoPerAnt[0] = new eSocialEvtDesligInfoDesligVerbasRescDmDevIdeADC();


            XmlSerializer xml = new XmlSerializer(typeof(eSocial));
            xml.Serialize(Console.Out, eSocialEvt);
            Console.Read();


        }
    }
}
