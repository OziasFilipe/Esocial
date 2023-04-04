using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using BibliotecaEsocial.ClassesEsquemas.S2190;
using BibliotecaEsocial.Validacao;

namespace BibliotecaEsocial.Eventos.S2190
{
    class S2190
    {
        public eSocial esocial = new eSocial();
        public eSocialEvtAdmPrelim AdmPrelim = new eSocialEvtAdmPrelim();
        public T_ideEmpregador IdeEmpregador = new T_ideEmpregador();
        public T_ideEvento_trab_admissao IdeEventoTrabAdmissao = new T_ideEvento_trab_admissao();
        public eSocialEvtAdmPrelimInfoRegPrelim AdmPrelimInfoRegPrelim = new eSocialEvtAdmPrelimInfoRegPrelim();
        public eSocialEvtAdmPrelimInfoRegPrelimInfoRegCTPS AdmPrelimInfoRegPrelimInfoRegCtps = new eSocialEvtAdmPrelimInfoRegPrelimInfoRegCTPS();
        public void S_2190()
        {
            AdmPrelim.Id = "";
            AdmPrelim.ideEmpregador = IdeEmpregador;
            AdmPrelim.ideEvento = IdeEventoTrabAdmissao;
            AdmPrelim.infoRegPrelim = AdmPrelimInfoRegPrelim;

            IdeEmpregador.nrInsc = "";
            IdeEmpregador.tpInsc = 0;

            IdeEventoTrabAdmissao.nrRecibo = "";
            IdeEventoTrabAdmissao.indRetif = 0;
            IdeEventoTrabAdmissao.procEmi = 0;
            IdeEventoTrabAdmissao.tpAmb = 0;
            IdeEventoTrabAdmissao.verProc = "";

            AdmPrelimInfoRegPrelim.codCateg = "";
            AdmPrelimInfoRegPrelim.cpfTrab = "";
            AdmPrelimInfoRegPrelim.dtAdm = DateTime.Now;
            AdmPrelimInfoRegPrelim.dtNascto = DateTime.Now;
            AdmPrelimInfoRegPrelim.infoRegCTPS = AdmPrelimInfoRegPrelimInfoRegCtps;
            AdmPrelimInfoRegPrelim.matricula = "";
            AdmPrelimInfoRegPrelim.natAtividadeSpecified = false;
            AdmPrelimInfoRegPrelim.natAtividade = 0;


            XmlSerializer xml = new XmlSerializer(typeof(eSocialEvtAdmPrelim));
            xml.Serialize(Console.Out, this.AdmPrelim);

            Console.ReadLine();
        }
    }
}
