using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using BibliotecaEsocial.Model.S1005;

namespace BibliotecaEsocial.Eventos.S1005
{
    class S1005
    {
        private eSocialEvtTabEstab evtTabEstab = new eSocialEvtTabEstab();
        private eSocialEvtTabEstabInfoEstab infoEstab = new eSocialEvtTabEstabInfoEstab();
        private T_ideEmpregador t_ideEmpregador = new T_ideEmpregador();
        private T_ideEvento_evtTab_inicial t_ideEvento_evtTab_inicial = new T_ideEvento_evtTab_inicial();
        private eSocialEvtTabEstabInfoEstab item = new eSocialEvtTabEstabInfoEstab();



        public string id = string.Empty;
        public string nrInsc = string.Empty;
        public sbyte tpInsc = 0;
        public sbyte procEmi = 0;
        public sbyte tpAmb = 0;
        public string verProc = string.Empty;


        public void s1005()
        {
            this.evtTabEstab.Id = this.id;
            this.evtTabEstab.ideEmpregador = this.t_ideEmpregador;
            this.evtTabEstab.infoEstab = this.infoEstab;
            this.evtTabEstab.ideEvento = this.t_ideEvento_evtTab_inicial;

            this.t_ideEmpregador.nrInsc = this.nrInsc;
            this.t_ideEmpregador.tpInsc = this.tpInsc;

            this.infoEstab.Item = this.item.Item; // com problema!! 

            
            
            this.t_ideEvento_evtTab_inicial.procEmi = this.procEmi;
            this.t_ideEvento_evtTab_inicial.tpAmb = this.tpAmb;
            this.t_ideEvento_evtTab_inicial.verProc = this.verProc;

           XmlSerializer xmlSerializer = new XmlSerializer(typeof(eSocialEvtTabEstab));
           xmlSerializer.Serialize(Console.Out, evtTabEstab);
           Console.ReadLine();
        }

    }
}
