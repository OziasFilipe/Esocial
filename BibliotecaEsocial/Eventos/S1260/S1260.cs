using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using BibliotecaEsocial.Model.S1260;

namespace BibliotecaEsocial.Eventos.S1260
{
    class S1260
    {
        private eSocial eSocialEvt = new eSocial();
        private eSocialEvtComProd evtComProd = new eSocialEvtComProd();
        private eSocialEvtComProdIdeEmpregador t_ideEmpregador = new eSocialEvtComProdIdeEmpregador();
        private T_ideEvento_folha_mensal_PF t_ideEvento = new T_ideEvento_folha_mensal_PF();
        private eSocialEvtComProdInfoComProd infoComProd = new eSocialEvtComProdInfoComProd();
        private eSocialEvtComProdInfoComProdIdeEstabel ideEstab = new eSocialEvtComProdInfoComProdIdeEstabel();

        private eSocialEvtComProdInfoComProdIdeEstabelTpComerc[] tpComerc =
            new eSocialEvtComProdInfoComProdIdeEstabelTpComerc[1];

        private eSocialEvtComProdInfoComProdIdeEstabelTpComercIdeAdquir[] ideAdquir =
            new eSocialEvtComProdInfoComProdIdeEstabelTpComercIdeAdquir[1];

        private eSocialEvtComProdInfoComProdIdeEstabelTpComercIdeAdquirNfs[] nfs =
            new eSocialEvtComProdInfoComProdIdeEstabelTpComercIdeAdquirNfs[1];

        private eSocialEvtComProdInfoComProdIdeEstabelTpComercInfoProcJud[] infoProcJud =
            new eSocialEvtComProdInfoComProdIdeEstabelTpComercInfoProcJud[1];

        private string id = string.Empty;
        private string perApur = string.Empty;
        private string nrInsc = string.Empty;
        private sbyte indGuia = 0;
        private sbyte tpInsc = 0;
        private sbyte indComerc = 0;
        private string nrInscEstabRural = string.Empty;
        private sbyte tpInsc2 = 0;
        private string nrInsc2= string.Empty;
        private string serie= string.Empty;
        private string nrDocto = string.Empty;
        private sbyte tpProc = 0;
        private string nrProc = string.Empty;
        private string codSusp = string.Empty;


        public void s1260()
        {
            this.eSocialEvt = this.eSocialEvt;
            this.eSocialEvt.evtComProd = this.evtComProd;

            this.evtComProd.Id = this.id;
            this.evtComProd.ideEmpregador = this.t_ideEmpregador;
            this.evtComProd.ideEvento = this.t_ideEvento;
            this.evtComProd.infoComProd = this.infoComProd;

            this.t_ideEvento.perApur = this.perApur;
            this.t_ideEvento.indGuia = this.indGuia;

            this.t_ideEmpregador.nrInsc = this.nrInsc;
            this.t_ideEmpregador.tpInsc = this.tpInsc;

            this.infoComProd.ideEstabel = this.ideEstab;
            this.ideEstab.tpComerc = this.tpComerc;
            this.ideEstab.nrInscEstabRural = this.nrInscEstabRural;

            this.tpComerc[0] = new eSocialEvtComProdInfoComProdIdeEstabelTpComerc();
            this.tpComerc[0].indComerc = this.indComerc;
            this.tpComerc[0].ideAdquir = this.ideAdquir;

            this.ideAdquir[0] = new eSocialEvtComProdInfoComProdIdeEstabelTpComercIdeAdquir();
            this.ideAdquir[0].tpInsc = this.tpInsc2;
            this.ideAdquir[0].nrInsc = this.nrInsc2;
            this.ideAdquir[0].nfs = this.nfs;

            this.nfs[0] = new eSocialEvtComProdInfoComProdIdeEstabelTpComercIdeAdquirNfs();
            this.nfs[0].serie = this.serie;
            this.nfs[0].nrDocto = this.nrDocto;

            this.tpComerc[0].infoProcJud = this.infoProcJud;

            this.infoProcJud[0] = new eSocialEvtComProdInfoComProdIdeEstabelTpComercInfoProcJud();
            this.infoProcJud[0].tpProc = this.tpProc;
            this.infoProcJud[0].nrProc = this.nrProc;
            this.infoProcJud[0].codSusp = this.codSusp;

            XmlSerializer xml = new XmlSerializer(typeof(eSocial));
            xml.Serialize(Console.Out, eSocialEvt);
            Console.Read();
        }
    }
}
