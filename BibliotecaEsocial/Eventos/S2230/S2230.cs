using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using BibliotecaEsocial.Model.S2230;

namespace BibliotecaEsocial.Eventos.S2230
{
    class S2230
    {
        private eSocialEvtAfastTemp evtAfastTemp = new eSocialEvtAfastTemp();
        private T_ideEmpregador t_ideEmpregador = new T_ideEmpregador();
        private T_ideEvento_trab t_ideEvento = new T_ideEvento_trab();
        private eSocialEvtAfastTempIdeVinculo ideVinculo = new eSocialEvtAfastTempIdeVinculo();
        private eSocialEvtAfastTempInfoAfastamento infoAfastamento = new eSocialEvtAfastTempInfoAfastamento();

        private eSocialEvtAfastTempInfoAfastamentoIniAfastamento iniAfastamento =
            new eSocialEvtAfastTempInfoAfastamentoIniAfastamento();

        private eSocialEvtAfastTempInfoAfastamentoIniAfastamentoPerAquis perAquis =
            new eSocialEvtAfastTempInfoAfastamentoIniAfastamentoPerAquis();

        private eSocialEvtAfastTempInfoAfastamentoIniAfastamentoInfoCessao infoCessao =
            new eSocialEvtAfastTempInfoAfastamentoIniAfastamentoInfoCessao();

        private eSocialEvtAfastTempInfoAfastamentoIniAfastamentoInfoMandSind infoMandSind =
            new eSocialEvtAfastTempInfoAfastamentoIniAfastamentoInfoMandSind();

        private eSocialEvtAfastTempInfoAfastamentoIniAfastamentoInfoMandElet infoMandElet =
            new eSocialEvtAfastTempInfoAfastamentoIniAfastamentoInfoMandElet();

        private eSocialEvtAfastTempInfoAfastamentoInfoRetif infoRetif =
            new eSocialEvtAfastTempInfoAfastamentoInfoRetif();

        private eSocialEvtAfastTempInfoAfastamentoFimAfastamento fimAfastamento =
            new eSocialEvtAfastTempInfoAfastamentoFimAfastamento();


        private string id = string.Empty;
        private string nrInsc = string.Empty;
        private sbyte tpInsc = 0;
        private string matricula = string.Empty;
        private string codCateg = string.Empty;
        private string cpfTrab = string.Empty;
        private DateTime dtIniAfast = DateTime.Now;
        private DateTime dtTermAfast = DateTime.Now;

        public void s2230()
        {
            this.evtAfastTemp.Id = this.id;
            this.evtAfastTemp.ideEmpregador = this.t_ideEmpregador;
            this.evtAfastTemp.ideEvento = this.t_ideEvento;
            this.evtAfastTemp.ideVinculo = this.ideVinculo;
            this.evtAfastTemp.infoAfastamento = this.infoAfastamento;

            this.t_ideEmpregador.nrInsc = this.nrInsc;
            this.t_ideEmpregador.tpInsc = this.tpInsc;

            this.ideVinculo.matricula = this.matricula;
            this.ideVinculo.codCateg = this.codCateg;
            this.ideVinculo.cpfTrab = this.cpfTrab;

            this.infoAfastamento.iniAfastamento = this.iniAfastamento;

            this.iniAfastamento.dtIniAfast = this.dtIniAfast;
            this.iniAfastamento.perAquis = this.perAquis;
            this.iniAfastamento.infoCessao = this.infoCessao;
            this.iniAfastamento.infoMandSind = this.infoMandSind;
            this.iniAfastamento.infoMandElet = this.infoMandElet;

            this.infoAfastamento.infoRetif = this.infoRetif;
            this.infoAfastamento.fimAfastamento = this.fimAfastamento;
            
            this.fimAfastamento.dtTermAfast = this.dtTermAfast;

            XmlSerializer xml = new XmlSerializer(typeof(eSocialEvtAfastTemp));
            xml.Serialize(Console.Out, evtAfastTemp);
            Console.ReadLine();
        }
    }
}