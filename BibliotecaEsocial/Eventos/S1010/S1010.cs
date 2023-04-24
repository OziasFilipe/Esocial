using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BibliotecaEsocial.Model.S1010;
using BibliotecaEsocial.Model.S5002;
using T_ideEmpregador = BibliotecaEsocial.Model.S1010.T_ideEmpregador;

namespace BibliotecaEsocial.Eventos.S1010
{
    class S1010
    {
        private eSocialEvtTabRubrica evtTabRubrica = new eSocialEvtTabRubrica();
        private T_ideEmpregador t_ideEmpregador = new T_ideEmpregador();
        private T_ideEvento_evtTab t_ideEvento = new T_ideEvento_evtTab();
        private eSocialEvtTabRubricaInfoRubrica evtInfoRubrica = new eSocialEvtTabRubricaInfoRubrica();
       // private eSocialEvtTabRubricaInfoRubrica item = new eSocialEvtTabRubricaInfoRubrica();


        public string id;
        public sbyte tpInsc = 0;
        public string nrInsc = string.Empty;
        public object teste = new object();

        public void s1010()
        {
            this.evtTabRubrica.Id = this.id;
            this.evtTabRubrica.ideEvento = this.t_ideEvento;
            this.evtTabRubrica.ideEmpregador = this.t_ideEmpregador;
            this.evtTabRubrica.infoRubrica = this.evtInfoRubrica;

            this.evtInfoRubrica = new eSocialEvtTabRubricaInfoRubrica();  // com problema!
            this.evtInfoRubrica.Item = this.teste;
            




            this.t_ideEmpregador.tpInsc = this.tpInsc;
            this.t_ideEmpregador.nrInsc = this.nrInsc;






        }
    }
}
