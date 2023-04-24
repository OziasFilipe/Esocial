using System;
using System.Collections;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using BibliotecaEsocial.Model.S2231;

namespace BibliotecaEsocial.Eventos.S2231
{
    class S2231
    {
        private eSocialEvtCessao evtCessao = new eSocialEvtCessao();
        private T_ideEmpregador_cnpj t_ideEmpregador = new T_ideEmpregador_cnpj();
        private T_ideEvento_trab_PJ t_ideEvento = new T_ideEvento_trab_PJ();
        private T_ideVinculo t_ideVinculo = new T_ideVinculo();
        private eSocialEvtCessaoInfoCessao infoCessao = new eSocialEvtCessaoInfoCessao();
        private eSocialEvtCessaoInfoCessaoFimCessao fimCessao = new eSocialEvtCessaoInfoCessaoFimCessao();
        private eSocialEvtCessaoInfoCessaoIniCessao iniCessao = new eSocialEvtCessaoInfoCessaoIniCessao();


        private string id = string.Empty;
        private string nrInsc = string.Empty;
        private sbyte tpInsc = 0;
        private string matricula = string.Empty;
        private string codCateg = string.Empty;
        private string cpfTrab = string.Empty;
        private DateTime dtTermCessao = DateTime.Now;
        private DateTime dtIniCessao = DateTime.Now;

        public void s2231()
        {
            this.evtCessao.Id = this.id;
            this.evtCessao.ideEmpregador = this.t_ideEmpregador;
            this.evtCessao.ideEvento = this.t_ideEvento;
            this.evtCessao.ideVinculo =this.t_ideVinculo;
            this.evtCessao.infoCessao = this.infoCessao;

            this.t_ideEmpregador.nrInsc = this.nrInsc;
            this.t_ideEmpregador.tpInsc = this.tpInsc;

            this.t_ideVinculo.matricula = this.matricula;
            this.t_ideVinculo.cpfTrab = this.cpfTrab;


            this.infoCessao.FimCessao = this.fimCessao;
            this.fimCessao.dtTermCessao = this.dtTermCessao;
            this.infoCessao.IniCessao = this.iniCessao;
            this.iniCessao.dtIniCessao = this.dtIniCessao;
            

            XmlSerializer xml = new XmlSerializer(typeof(eSocialEvtCessao));
            xml.Serialize(Console.Out, evtCessao);
            Console.ReadLine();
        }
    }
}