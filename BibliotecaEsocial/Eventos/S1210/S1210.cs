using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BibliotecaEsocial.Model.S1210;

namespace BibliotecaEsocial.Eventos.S1210
{
    class S1210
    {
        private eSocial eSocialEvt = new eSocial();
        private eSocialEvtPgtos evtPgtos = new eSocialEvtPgtos();
        private T_ideEvento_folha_mensal t_ideEvento = new T_ideEvento_folha_mensal();
        private T_ideEmpregador t_ideEmpregador = new T_ideEmpregador();
        private eSocialEvtPgtosIdeBenef ideBenef = new eSocialEvtPgtosIdeBenef();
        private eSocialEvtPgtosIdeBenefInfoPgto[] infoPgtos = new eSocialEvtPgtosIdeBenefInfoPgto[1];

        private string id = string.Empty;
        private string perApur = string.Empty;
        private string nrInsc = string.Empty;
        private string cpfBenef = string.Empty;
        private sbyte indGuia = 0;
        private sbyte tpInsc = 0;
        public void s1210()
        {
            this.eSocialEvt = this.eSocialEvt;
            this.eSocialEvt.evtPgtos = this.evtPgtos;

            this.evtPgtos.Id = this.id;
            this.evtPgtos.ideEvento  = this.t_ideEvento;
            this.evtPgtos.ideEmpregador = this.t_ideEmpregador;
            this.evtPgtos.ideBenef = this.ideBenef;

            this.t_ideEvento.perApur = this.perApur;
            this.t_ideEvento.indGuia = this.indGuia;

            this.t_ideEmpregador.tpInsc = this.tpInsc;
            this.t_ideEmpregador.nrInsc = this.nrInsc;

            this.ideBenef.cpfBenef = this.cpfBenef;
            this.ideBenef.infoPgto = this.infoPgtos;

            this.infoPgtos[0] = new eSocialEvtPgtosIdeBenefInfoPgto();
            this.infoPgtos[0].tpPgto = 0;
            this.infoPgtos[0].perRef = "";
            this.infoPgtos[0].ideDmDev = "";
           // this.infoPgtos[0].







        }
    }
}
