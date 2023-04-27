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
        private eSocialEvtTabRubricaInfoRubricaInclusao inclusao = new eSocialEvtTabRubricaInfoRubricaInclusao();
        private eSocialEvtTabRubricaInfoRubricaExclusao exclusao = new eSocialEvtTabRubricaInfoRubricaExclusao();
        private eSocialEvtTabRubricaInfoRubricaAlteracao alteracao = new eSocialEvtTabRubricaInfoRubricaAlteracao();
        private T_ideRubrica ideRubrica = new T_ideRubrica();
        private T_dadosRubrica dadosRubrica = new T_dadosRubrica();
        private T_dadosRubricaIdeProcessoCP[] ideProcessoCp = new T_dadosRubricaIdeProcessoCP[1];
        private T_dadosRubricaIdeProcessoIRRF[] ideProcessoIrrf = new T_dadosRubricaIdeProcessoIRRF[1];
        private T_dadosRubricaIdeProcessoFGTS[] ideProcessoFgts = new T_dadosRubricaIdeProcessoFGTS[1];
        private T_novaValidade novaValidade = new T_novaValidade();

        private string id = string.Empty;
        private string nrInsc = string.Empty;
        private string verProc = string.Empty;
        private sbyte tpInsc = 0;
        private sbyte procEmi = 0;
        private sbyte tpAmb = 0;
        private string codRubr = string.Empty;
        private string ideTabRubr = string.Empty;
        private string iniValid = string.Empty;
        private string fimValid = string.Empty;
        private string nrProc = string.Empty;



        public void s1010()
        {
            this.evtTabRubrica.ideEmpregador = this.t_ideEmpregador;
            this.evtTabRubrica.ideEvento = this.t_ideEvento_evtTab;
            this.evtTabRubrica.infoRubrica = this.infoRubrica;
            this.evtTabRubrica.Id = this.id;

            this.t_ideEmpregador.nrInsc = this.nrInsc;
            this.t_ideEmpregador.tpInsc = this.tpInsc;

            this.t_ideEvento_evtTab.verProc = this.verProc;
            this.t_ideEvento_evtTab.procEmi = this.procEmi;
            this.t_ideEvento_evtTab.tpAmb = this.tpAmb;

            this.infoRubrica.inclusao = this.inclusao;

            this.inclusao.ideRubrica = this.ideRubrica;
            this.inclusao.dadosRubrica = this.dadosRubrica;

            this.ideRubrica.codRubr = this.codRubr;
            this.ideRubrica.ideTabRubr = this.ideTabRubr;
            this.ideRubrica.iniValid = this.iniValid;
            this.ideRubrica.fimValid = this.fimValid;

            this.dadosRubrica.ideProcessoCP = this.ideProcessoCp;

            this.ideProcessoCp[0] = new T_dadosRubricaIdeProcessoCP();
            this.ideProcessoCp[0].nrProc = this.nrProc;

            this.dadosRubrica.ideProcessoIRRF = this.ideProcessoIrrf;

            this.ideProcessoIrrf[0] = new T_dadosRubricaIdeProcessoIRRF();
            this.ideProcessoIrrf[0].nrProc = this.nrProc;

            this.dadosRubrica.ideProcessoFGTS = this.ideProcessoFgts;
            
            this.ideProcessoFgts[0] = new T_dadosRubricaIdeProcessoFGTS();
            this.ideProcessoFgts[0].nrProc = this.nrProc;

            this.infoRubrica.alteracao = this.alteracao;

            this.alteracao.ideRubrica = this.ideRubrica;
            this.alteracao.dadosRubrica = this.dadosRubrica;
            this.alteracao.novaValidade = this.novaValidade;

            this.infoRubrica.exclusao = this.exclusao;
            this.exclusao.ideRubrica = this.ideRubrica;
            

            XmlSerializer xml = new XmlSerializer(typeof(eSocialEvtTabRubrica));
            xml.Serialize(Console.Out, evtTabRubrica);
            Console.ReadLine();
        }

    }
}
