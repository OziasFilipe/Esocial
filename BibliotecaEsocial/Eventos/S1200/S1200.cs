using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BibliotecaEsocial.Model.S1200;

namespace BibliotecaEsocial.Eventos.S1200
{
    class S1200
    {
        private eSocialEvtRemun evtRemun = new eSocialEvtRemun();
        private T_ideEvento_folha t_ideEvento = new T_ideEvento_folha();
        private T_ideEmpregador t_ideEmpregador = new T_ideEmpregador();
        private eSocialEvtRemunIdeTrabalhador t_ideTrabalhador = new eSocialEvtRemunIdeTrabalhador();
        private eSocialEvtRemunIdeTrabalhadorInfoMV infoMv = new eSocialEvtRemunIdeTrabalhadorInfoMV();
        private eSocialEvtRemunIdeTrabalhadorInfoComplem infoComplem = new eSocialEvtRemunIdeTrabalhadorInfoComplem();

        private eSocialEvtRemunIdeTrabalhadorInfoMVRemunOutrEmpr[] remunOutrEmpr =
            new eSocialEvtRemunIdeTrabalhadorInfoMVRemunOutrEmpr[1];

        private eSocialEvtRemunIdeTrabalhadorInfoComplemSucessaoVinc sucessaoVinc =
            new eSocialEvtRemunIdeTrabalhadorInfoComplemSucessaoVinc();

        private T_procJudTrab[] procJud = new T_procJudTrab[1];
        private T_infoInterm[] infoInterm = new T_infoInterm[1];
        private eSocialEvtRemunDmDev[] dmDev = new eSocialEvtRemunDmDev[1];


        private string id = string.Empty;
        private string perApur = string.Empty;
        private string nrInsc = string.Empty;
        private string cpfTrab = string.Empty;
        private sbyte indApuracao = 0;
        private sbyte indGuia = 0;
        private sbyte tpInsc = 0;
        private string nrInscMV = string.Empty;
        private sbyte tpInscMV = 0;
        private string codCategMV = string.Empty;
        private string codSusp = string.Empty;
        private string nrProcJud = string.Empty;
        private sbyte tpTrib = 0;
        private sbyte dia = 0;
        private string ideDmDev = string.Empty;

        public void s1200()
        {
            this.evtRemun.Id = this.id;
            this.evtRemun.ideEvento = this.t_ideEvento;
            this.evtRemun.ideEmpregador = this.t_ideEmpregador;
            this.evtRemun.ideTrabalhador = this.t_ideTrabalhador;

            this.t_ideEvento.indApuracao = this.indApuracao;
            this.t_ideEvento.perApur = this.perApur;
            this.t_ideEvento.indGuia = this.indGuia;

            this.t_ideEmpregador.nrInsc = this.nrInsc;
            this.t_ideEmpregador.tpInsc = this.tpInsc;

            this.t_ideTrabalhador.cpfTrab = this.cpfTrab;

            this.t_ideTrabalhador.infoMV =this.infoMv;
            this.t_ideTrabalhador.infoComplem = this.infoComplem;

            this.infoMv.remunOutrEmpr = this.remunOutrEmpr;
            this.remunOutrEmpr[0].nrInsc = this.nrInscMV;
            this.remunOutrEmpr[0].tpInsc = this.tpInscMV;
            this.remunOutrEmpr[0].codCateg = this.codCategMV;

            this.infoComplem.sucessaoVinc = this.sucessaoVinc;
            this.t_ideTrabalhador.procJudTrab = this.procJud;

            this.procJud[0].tpTrib = this.tpTrib;
            this.procJud[0].nrProcJud = this.nrProcJud;
            this.procJud[0].codSusp = this.codSusp;

            this.t_ideTrabalhador.infoInterm = this.infoInterm;
            this.infoInterm[0].dia = this.dia;

            this.evtRemun.dmDev = this.dmDev;
            this.dmDev[0] = new eSocialEvtRemunDmDev();

            this.dmDev[0].ideDmDev = this.ideDmDev;
            // this.dmDev[0]
            



        }
    }
}