using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using BibliotecaEsocial.Model.S2190;
using BibliotecaEsocial.Validacao;

namespace BibliotecaEsocial.Eventos.S2190
{
    class S2190
    {
        private eSocial esocial = new eSocial();
        private eSocialEvtAdmPrelim AdmPrelim = new eSocialEvtAdmPrelim();
        private T_ideEmpregador IdeEmpregador = new T_ideEmpregador();
        private T_ideEvento_trab_admissao IdeEventoTrabAdmissao = new T_ideEvento_trab_admissao();
        private eSocialEvtAdmPrelimInfoRegPrelim AdmPrelimInfoRegPrelim = new eSocialEvtAdmPrelimInfoRegPrelim();
        private eSocialEvtAdmPrelimInfoRegPrelimInfoRegCTPS AdmPrelimInfoRegPrelimInfoRegCtps = new eSocialEvtAdmPrelimInfoRegPrelimInfoRegCTPS();

        //Atributos a serem preechidos 
        public string id;
        public string nrInsc = "";
        public sbyte tpInsc = 0;
        public string nrRecibo = "";
        public sbyte indRetif = 0;
        public sbyte procEmi = 0;
        public sbyte tpAmb = 0;
        public string verProc = "";
        public string codCateg = "";
        public string cpfTrab = "";
        public DateTime dtAdm = DateTime.Now;
        public DateTime dtNascto = DateTime.Now;
        public string matricula = "";
        public bool natAtividadeSpecified = false;
        public sbyte natAtividade = 0;

        public void S_2190()
        {
            this.AdmPrelim.Id = this.id;
            this.AdmPrelim.ideEmpregador = this.IdeEmpregador;
            this.AdmPrelim.ideEvento = this.IdeEventoTrabAdmissao;
            this.AdmPrelim.infoRegPrelim = this.AdmPrelimInfoRegPrelim;

            this.IdeEmpregador.nrInsc = this.nrInsc;
            this.IdeEmpregador.tpInsc = this.tpInsc;

            this.IdeEventoTrabAdmissao.nrRecibo = this.nrRecibo;
            this.IdeEventoTrabAdmissao.indRetif = this.indRetif;
            this.IdeEventoTrabAdmissao.procEmi = this.procEmi;
            this.IdeEventoTrabAdmissao.tpAmb = this.tpAmb;
            this.IdeEventoTrabAdmissao.verProc = this.verProc;

            this.AdmPrelimInfoRegPrelim.codCateg = this.codCateg;
            this.AdmPrelimInfoRegPrelim.cpfTrab = this.cpfTrab;
            this.AdmPrelimInfoRegPrelim.dtAdm = this.dtAdm;
            this.AdmPrelimInfoRegPrelim.dtNascto = this.dtNascto;
            this.AdmPrelimInfoRegPrelim.infoRegCTPS = this.AdmPrelimInfoRegPrelimInfoRegCtps;
            this.AdmPrelimInfoRegPrelim.matricula = this.matricula;
            this.AdmPrelimInfoRegPrelim.natAtividadeSpecified = this.natAtividadeSpecified;
            this.AdmPrelimInfoRegPrelim.natAtividade = this.natAtividade;

            //Serializar Objeto em XML 
            XmlSerializer xml = new XmlSerializer(typeof(eSocialEvtAdmPrelim));
            xml.Serialize(Console.Out, this.AdmPrelim);

            Console.ReadLine();
        }
    }
}
