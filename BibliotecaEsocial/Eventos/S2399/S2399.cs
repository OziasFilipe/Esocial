using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BibliotecaEsocial.Model.S2399;

namespace BibliotecaEsocial.Eventos.S2399
{
    class S2399
    {
        private eSocialEvtTSVTermino evtTsvTermino = new eSocialEvtTSVTermino();
        private T_ideEmpregador t_ideEmpregador = new T_ideEmpregador();
        private T_ideEvento_trab_indGuia t_ideEvento = new T_ideEvento_trab_indGuia();
        private T_ideTrabSemVinculo ideTrabSemVinculo = new T_ideTrabSemVinculo();
        private eSocialEvtTSVTerminoInfoTSVTermino infoTsvTermino = new eSocialEvtTSVTerminoInfoTSVTermino();

        private eSocialEvtTSVTerminoInfoTSVTerminoMudancaCPF mudancaCpf =
            new eSocialEvtTSVTerminoInfoTSVTerminoMudancaCPF();

        private eSocialEvtTSVTerminoInfoTSVTerminoVerbasResc verbasResc =
            new eSocialEvtTSVTerminoInfoTSVTerminoVerbasResc();

        private eSocialEvtTSVTerminoInfoTSVTerminoVerbasRescDmDev[] dmDev =
            new eSocialEvtTSVTerminoInfoTSVTerminoVerbasRescDmDev[1];

        private string id = string.Empty;
        private string nrInsc = string.Empty;
        private sbyte tpInsc = 0;
        private string matricula = string.Empty;
        private string codCateg = string.Empty;
        private string cpfTrab = string.Empty;
        private DateTime dtTerm = DateTime.Now;
        public void s2399()
        {
            this.evtTsvTermino.Id = this.id;
            this.evtTsvTermino.ideEmpregador = this.t_ideEmpregador;
            this.evtTsvTermino.ideEvento = this.t_ideEvento;
            this.evtTsvTermino.ideTrabSemVinculo = this.ideTrabSemVinculo;
            this.evtTsvTermino.infoTSVTermino = this.infoTsvTermino;

            this.infoTsvTermino.dtTerm = this.dtTerm;

            this.t_ideEmpregador.nrInsc = this.nrInsc;
            this.t_ideEmpregador.tpInsc = this.tpInsc;

            this.ideTrabSemVinculo.matricula = this.matricula;
            this.ideTrabSemVinculo.cpfTrab = this.cpfTrab;
            this.ideTrabSemVinculo.codCateg = this.codCateg;

            this.infoTsvTermino.mudancaCPF = this.mudancaCpf;
            this.infoTsvTermino.verbasResc = this.verbasResc;

            this.verbasResc.dmDev = this.dmDev;
            this.dmDev[0].ideDmDev = "";
            
            // resolver; 
        }
    }
}
