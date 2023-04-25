using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BibliotecaEsocial.Model.S2299;

namespace BibliotecaEsocial.Eventos.S2299
{
    class S2299
    {
        private eSocialEvtDeslig evtDeslig = new eSocialEvtDeslig();
        private T_ideEmpregador t_ideEmpregador = new T_ideEmpregador();
        private T_ideEvento_trab_indGuia t_ideEvento = new T_ideEvento_trab_indGuia();
        private T_ideVinculo t_ideVinculo = new T_ideVinculo();
        private eSocialEvtDesligInfoDeslig infoDeslig = new eSocialEvtDesligInfoDeslig();
        private T_infoInterm[] infoInterm = new T_infoInterm[1];
        private eSocialEvtDesligInfoDesligObservacoes[] observacoes = new eSocialEvtDesligInfoDesligObservacoes[1];
        private eSocialEvtDesligInfoDesligSucessaoVinc sucessaoVinc = new eSocialEvtDesligInfoDesligSucessaoVinc();
        private eSocialEvtDesligInfoDesligTransfTit transfTit = new eSocialEvtDesligInfoDesligTransfTit();
        private eSocialEvtDesligInfoDesligMudancaCPF mudancaCpf = new eSocialEvtDesligInfoDesligMudancaCPF();
        private eSocialEvtDesligInfoDesligVerbasResc verbasResc = new eSocialEvtDesligInfoDesligVerbasResc();
        private eSocialEvtDesligInfoDesligVerbasRescDmDev[] dmDev = new eSocialEvtDesligInfoDesligVerbasRescDmDev[1];

        private string id = string.Empty;
        private string nrInsc = string.Empty;
        private sbyte tpInsc = 0;
        private string matricula = string.Empty;
        private string cpfTrab = string.Empty;
        private DateTime dtDeslig  = DateTime.Now;
        private string ideDmDev = string.Empty;
        private sbyte dia = 0;

        public void s2299()
        {
            this.evtDeslig.Id = this.id;
            this.evtDeslig.ideEmpregador = this.t_ideEmpregador;
            this.evtDeslig.ideEvento = this.t_ideEvento;
            this.evtDeslig.ideVinculo = this.t_ideVinculo;
            this.evtDeslig.infoDeslig = this.infoDeslig;

            this.t_ideEmpregador.nrInsc = this.nrInsc;
            this.t_ideEmpregador.tpInsc = this.tpInsc;

            this.t_ideVinculo.matricula = this.matricula;
            this.t_ideVinculo.cpfTrab = this.cpfTrab;

            this.infoDeslig.dtDeslig = this.dtDeslig;
            this.infoInterm[0] = new T_infoInterm();
            this.infoInterm[0].dia = this.dia;
            this.observacoes[0] = new eSocialEvtDesligInfoDesligObservacoes();
            this.infoDeslig.sucessaoVinc = this.sucessaoVinc;
            this.infoDeslig.transfTit = this.transfTit;
            this.infoDeslig.mudancaCPF = this.mudancaCpf;
            this.infoDeslig.verbasResc = this.verbasResc;
            this.dmDev[0] = new eSocialEvtDesligInfoDesligVerbasRescDmDev();
            this.dmDev[0].ideDmDev = this.ideDmDev;
           

            // terminar 






        }
    }
}
