using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using BibliotecaEsocial.Model.S5002;

namespace BibliotecaEsocial.Eventos.S5002
{
    class S5002
    {
        private eSocial eSocial = new eSocial();
        private eSocialEvtIrrfBenef evtIrrfBenef = new eSocialEvtIrrfBenef();
        private eSocialEvtIrrfBenefIdeEvento t_ideEvento = new eSocialEvtIrrfBenefIdeEvento();
        private eSocialEvtIrrfBenefIdeTrabalhador t_ideTrabalhador = new eSocialEvtIrrfBenefIdeTrabalhador();
        private T_ideEmpregador t_ideEmpregador = new T_ideEmpregador();
        private eSocialEvtIrrfBenefIdeTrabalhadorDmDev[] dmDev = new eSocialEvtIrrfBenefIdeTrabalhadorDmDev[1];

        private eSocialEvtIrrfBenefIdeTrabalhadorDmDevInfoIR[] infoIr =
            new eSocialEvtIrrfBenefIdeTrabalhadorDmDevInfoIR[1];

        private eSocialEvtIrrfBenefIdeTrabalhadorDmDevTotApurMen[] totApurMen =
            new eSocialEvtIrrfBenefIdeTrabalhadorDmDevTotApurMen[1];

        private eSocialEvtIrrfBenefIdeTrabalhadorDmDevTotApurDia[] apurDia =
            new eSocialEvtIrrfBenefIdeTrabalhadorDmDevTotApurDia[1];

        private TS_CRMen crMen = new TS_CRMen();
        private TS_CRDia crDia = new TS_CRDia();

        private string id = string.Empty;
        private string nrInsc = string.Empty;
        private sbyte tpInsc = 0;
        private string perApur = string.Empty;
        private string cpfBenef = string.Empty;
        private string perRef = string.Empty;
        private string ideDmDev = string.Empty;
        private sbyte tpPgto = 0;
        private sbyte perApurDia = 0;

        public void s5002()
        {
            this.eSocial.evtIrrfBenef = this.evtIrrfBenef;
            this.evtIrrfBenef.Id = this.id;
            this.evtIrrfBenef.ideEvento = this.t_ideEvento;
            this.evtIrrfBenef.ideTrabalhador = this.t_ideTrabalhador;
            this.evtIrrfBenef.ideEmpregador = this.t_ideEmpregador;

            this.t_ideEvento.perApur = this.perApur;

            this.t_ideEmpregador.nrInsc = this.nrInsc;
            this.t_ideEmpregador.tpInsc = this.tpInsc;

            this.t_ideTrabalhador.cpfBenef = this.cpfBenef;
            this.t_ideTrabalhador.dmDev = this.dmDev;

            this.dmDev[0] = new eSocialEvtIrrfBenefIdeTrabalhadorDmDev();
            this.dmDev[0].perRef = this.perRef;
            this.dmDev[0].ideDmDev = this.ideDmDev;
            this.dmDev[0].tpPgto = this.tpPgto;
            this.dmDev[0].infoIR = this.infoIr;

            this.infoIr[0] = new eSocialEvtIrrfBenefIdeTrabalhadorDmDevInfoIR();

            this.dmDev[0].totApurMen =this.totApurMen;

            this.totApurMen[0] = new eSocialEvtIrrfBenefIdeTrabalhadorDmDevTotApurMen();
            this.totApurMen[0].CRMen = this.crMen;

            this.dmDev[0].totApurDia = this.apurDia;

            this.apurDia[0] = new eSocialEvtIrrfBenefIdeTrabalhadorDmDevTotApurDia();
            this.apurDia[0].perApurDia = this.perApurDia;
            this.apurDia[0].CRDia = this.crDia;

            XmlSerializer xml = new XmlSerializer(typeof(eSocial));
            xml.Serialize(Console.Out, eSocial);
            Console.Read();
        }
    }
}
