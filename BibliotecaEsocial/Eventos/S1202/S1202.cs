using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using BibliotecaEsocial.Model.S1202;

namespace BibliotecaEsocial.Eventos.S1202
{
    class S1202
    {
        private eSocial eSocialEvt = new eSocial();
        private eSocialEvtRmnRPPS evtRmnRpps = new eSocialEvtRmnRPPS();
        private T_ideEvento_folha_opp t_ideEvento = new T_ideEvento_folha_opp();
        private T_ideEmpregador_cnpj t_ideEmpregador = new T_ideEmpregador_cnpj();
        private eSocialEvtRmnRPPSIdeTrabalhador ideTrabalhador = new eSocialEvtRmnRPPSIdeTrabalhador();

        private eSocialEvtRmnRPPSIdeTrabalhadorInfoComplem infoComplem =
            new eSocialEvtRmnRPPSIdeTrabalhadorInfoComplem();

        private eSocialEvtRmnRPPSIdeTrabalhadorInfoComplemSucessaoVinc sucessaoVinc =
            new eSocialEvtRmnRPPSIdeTrabalhadorInfoComplemSucessaoVinc();

        private eSocialEvtRmnRPPSDmDev[] dmDev = new eSocialEvtRmnRPPSDmDev[1];
        private T_infoRRA infoRra = new T_infoRRA();
        private T_infoRRADespProcJud despProcJud = new T_infoRRADespProcJud();
        private T_infoRRAIdeAdv[] ideAdv = new T_infoRRAIdeAdv[1];
        private eSocialEvtRmnRPPSDmDevIdeEstab[] infoPerApur = new eSocialEvtRmnRPPSDmDevIdeEstab[1];
        private T_remunPer[] remunPer = new T_remunPer[1];
        private T_itensRemun_rpps[] itensRemunRpps = new T_itensRemun_rpps[1];
        private eSocialEvtRmnRPPSDmDevInfoPerAnt infoPerAnt = new eSocialEvtRmnRPPSDmDevInfoPerAnt();

        private eSocialEvtRmnRPPSDmDevInfoPerAntIdePeriodo[] idePeriodo =
            new eSocialEvtRmnRPPSDmDevInfoPerAntIdePeriodo[1];

        private eSocialEvtRmnRPPSDmDevInfoPerAntIdePeriodoIdeEstab[] ideEstab =
            new eSocialEvtRmnRPPSDmDevInfoPerAntIdePeriodoIdeEstab[1];

        private string id = string.Empty;
        private string perApur = string.Empty;
        private string nrInsc = string.Empty;
        private string cpfTrab = string.Empty;
        private sbyte tpInsc = 0;
        private sbyte indApuracao = 0;
        private string ideDmDev = string.Empty;
        private string nrInsc2 = string.Empty;
        private sbyte tpInsc2 = 0;
        private string nrInsc3 = string.Empty;
        private sbyte tpInsc3 = 0;
        private string matricula = string.Empty;
        private string perRef = string.Empty;
        private string nrInsc4 = string.Empty;
        private sbyte tpInsc4 = 0;



        public void s1202()
        {
            this.eSocialEvt = this.eSocialEvt;
            this.eSocialEvt.evtRmnRPPS = this.evtRmnRpps;

            this.evtRmnRpps.Id = this.id;
            this.evtRmnRpps.ideEvento = this.t_ideEvento;
            this.evtRmnRpps.ideEmpregador = this.t_ideEmpregador;
            this.evtRmnRpps.ideTrabalhador = this.ideTrabalhador;

            this.t_ideEvento.indApuracao = this.indApuracao;
            this.t_ideEvento.perApur = this.perApur;

            this.t_ideEmpregador.tpInsc = this.tpInsc;
            this.t_ideEmpregador.nrInsc = this.nrInsc;

            this.ideTrabalhador.cpfTrab = this.cpfTrab;
            this.ideTrabalhador.infoComplem = this.infoComplem;

            this.infoComplem.sucessaoVinc = this.sucessaoVinc;

            this.evtRmnRpps.dmDev = this.dmDev;

            this.dmDev[0] = new eSocialEvtRmnRPPSDmDev();
            this.dmDev[0].ideDmDev = this.ideDmDev;
            this.dmDev[0].infoRRA = this.infoRra;

            this.infoRra.despProcJud = this.despProcJud;
            this.infoRra.ideAdv = this.ideAdv;

            this.ideAdv[0] = new T_infoRRAIdeAdv();
            this.ideAdv[0].nrInsc = this.nrInsc2;
            this.ideAdv[0].tpInsc = this.tpInsc2;

            this.dmDev[0].infoPerApur = this.infoPerApur;

            this.infoPerApur[0] = new eSocialEvtRmnRPPSDmDevIdeEstab();
            this.infoPerApur[0].tpInsc = this.tpInsc3;
            this.infoPerApur[0].nrInsc = this.nrInsc3;
            this.infoPerApur[0].remunPerApur = this.remunPer;

            this.remunPer[0] = new T_remunPer();
            this.remunPer[0].matricula = this.matricula;
            this.remunPer[0].itensRemun = this.itensRemunRpps;

            this.dmDev[0].infoPerAnt = this.infoPerAnt;

            this.infoPerAnt.idePeriodo = this.idePeriodo;

            this.idePeriodo[0] = new eSocialEvtRmnRPPSDmDevInfoPerAntIdePeriodo();
            this.idePeriodo[0].perRef = this.perRef;
            this.idePeriodo[0].ideEstab = this.ideEstab;

            this.ideEstab[0] = new eSocialEvtRmnRPPSDmDevInfoPerAntIdePeriodoIdeEstab();
            this.ideEstab[0].nrInsc = this.nrInsc4;
            this.ideEstab[0].tpInsc= this.tpInsc4;
            this.ideEstab[0].remunPerAnt = this.remunPer;

            this.remunPer[0].matricula = this.matricula;

            XmlSerializer xml = new XmlSerializer(typeof(eSocial));
            xml.Serialize(Console.Out, eSocialEvt);
            Console.ReadLine();

        }
    }
}
