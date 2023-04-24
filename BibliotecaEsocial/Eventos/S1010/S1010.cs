using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using BibliotecaEsocial.Model.S1010;


namespace BibliotecaEsocial.Eventos.S1010
{
    class S1010
    {
        private eSocialEvtTabRubrica evtTabRubrica = new eSocialEvtTabRubrica();
        private T_ideEmpregador t_ideEmpregador = new T_ideEmpregador();
        private T_ideEvento_evtTab t_ideEvento_evtTab = new T_ideEvento_evtTab();
        private eSocialEvtTabRubricaInfoRubrica infoRubrica = new eSocialEvtTabRubricaInfoRubrica();

        private string id = string.Empty;
        public void s1010()
        {
            this.evtTabRubrica.ideEmpregador = this.t_ideEmpregador;
            this.evtTabRubrica.ideEvento = this.t_ideEvento_evtTab;
            this.evtTabRubrica.infoRubrica = this.infoRubrica;
            this.evtTabRubrica.Id = this.id;

            this.t_ideEmpregador.nrInsc = "";
            this.t_ideEmpregador.tpInsc = 0;

            this.t_ideEvento_evtTab.verProc = "";
            this.t_ideEvento_evtTab.procEmi = 0;
            this.t_ideEvento_evtTab.tpAmb = 0;

            this.infoRubrica.Item = new eSocialEvtTabRubricaInfoRubrica();

            XmlSerializer xml = new XmlSerializer(typeof(eSocialEvtTabRubrica));
            xml.Serialize(Console.Out, evtTabRubrica);
            Console.ReadLine();
        }

    }
}
