using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using BibliotecaEsocial.Model.S3500;

namespace BibliotecaEsocial.Eventos.S3500
{
    class S3500
    {
        private eSocial eSocialEvt = new eSocial();
        private eSocialEvtExcProcTrab evtExcProcTrab = new eSocialEvtExcProcTrab();
        private T_ideEvento_exclusao_proc_trab t_ideEvento = new T_ideEvento_exclusao_proc_trab();
        private T_ideEmpregador_exclusao t_ideEmpregador = new T_ideEmpregador_exclusao();
        private eSocialEvtExcProcTrabInfoExclusao infoExclusao = new eSocialEvtExcProcTrabInfoExclusao();

        private eSocialEvtExcProcTrabInfoExclusaoIdeProcTrab ideProcTrab =
            new eSocialEvtExcProcTrabInfoExclusaoIdeProcTrab();

        private string id = string.Empty;
        private string nrInsc = string.Empty;
        private sbyte tpInsc = 0;
        public void s3500()
        {
            this.eSocialEvt = this.eSocialEvt;
            this.eSocialEvt.evtExcProcTrab = this.evtExcProcTrab;

            this.evtExcProcTrab.Id = this.id;
            this.evtExcProcTrab.ideEvento = this.t_ideEvento;
            this.evtExcProcTrab.ideEmpregador = this.t_ideEmpregador;
            this.evtExcProcTrab.infoExclusao = this.infoExclusao;

            this.t_ideEmpregador.nrInsc = this.nrInsc;
            this.t_ideEmpregador.tpInsc = this.tpInsc;

            this.infoExclusao.ideProcTrab = this.ideProcTrab;

            XmlSerializer xml = new XmlSerializer(typeof(eSocial));
            xml.Serialize(Console.Out, eSocialEvt);
            Console.Read();
        }

    }
}
