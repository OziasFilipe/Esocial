using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using BibliotecaEsocial.Model.S2306;
using T_ideEmpregador = BibliotecaEsocial.Model.S2306.T_ideEmpregador;
using T_ideEvento_trab = BibliotecaEsocial.Model.S2306.T_ideEvento_trab;
using T_infoEstagiario = BibliotecaEsocial.Model.S2306.T_infoEstagiario;
using T_infoEstagiarioAgeIntegracao = BibliotecaEsocial.Model.S2306.T_infoEstagiarioAgeIntegracao;
using T_infoEstagiarioInstEnsino = BibliotecaEsocial.Model.S2306.T_infoEstagiarioInstEnsino;
using T_infoEstagiarioSupervisorEstagio = BibliotecaEsocial.Model.S2306.T_infoEstagiarioSupervisorEstagio;
using T_remuneracao = BibliotecaEsocial.Model.S2306.T_remuneracao;

namespace BibliotecaEsocial.Eventos.S2306
{
    
    class S2306
    {
        private eSocialEvtTSVAltContr evtTsvAltContr = new eSocialEvtTSVAltContr();
        private T_ideEmpregador t_ideEmpregador = new T_ideEmpregador();
        private T_ideEvento_trab t_ideEvento = new T_ideEvento_trab();
        private T_ideTrabSemVinculo t_ideSemVinculo = new T_ideTrabSemVinculo();
        private eSocialEvtTSVAltContrInfoTSVAlteracao infoTsvAlteracao = new eSocialEvtTSVAltContrInfoTSVAlteracao();

        private eSocialEvtTSVAltContrInfoTSVAlteracaoInfoComplementares infoComplementares =
            new eSocialEvtTSVAltContrInfoTSVAlteracaoInfoComplementares();
        private eSocialEvtTSVAltContrInfoTSVAlteracaoInfoComplementaresCargoFuncao cargoFuncao =
            new eSocialEvtTSVAltContrInfoTSVAlteracaoInfoComplementaresCargoFuncao();

        private T_remuneracao remuneracao = new T_remuneracao();

        private eSocialEvtTSVAltContrInfoTSVAlteracaoInfoComplementaresInfoDirigenteSindical infoDirigenteSindical =
            new eSocialEvtTSVAltContrInfoTSVAlteracaoInfoComplementaresInfoDirigenteSindical();

        private eSocialEvtTSVAltContrInfoTSVAlteracaoInfoComplementaresInfoTrabCedido infoTrabCedido =
            new eSocialEvtTSVAltContrInfoTSVAlteracaoInfoComplementaresInfoTrabCedido();

        private eSocialEvtTSVAltContrInfoTSVAlteracaoInfoComplementaresInfoMandElet infoMandElet =
            new eSocialEvtTSVAltContrInfoTSVAlteracaoInfoComplementaresInfoMandElet();


        private T_infoEstagiario infoEstagiario = new T_infoEstagiario();
        private T_infoEstagiarioInstEnsino instEnsino = new T_infoEstagiarioInstEnsino();
        private T_infoEstagiarioAgeIntegracao ageIntegracao = new T_infoEstagiarioAgeIntegracao();
        private T_infoEstagiarioSupervisorEstagio supervisorEstagio = new T_infoEstagiarioSupervisorEstagio();

        private string id = string.Empty;
        private string nrInsc = string.Empty;
        private sbyte tpInsc = 0;
        private string matricula = string.Empty;
        private string codCateg = string.Empty;
        private string cpfTrab = string.Empty;
        private DateTime dtAlteracao = DateTime.Now;


        public void s2306()
        {
            this.evtTsvAltContr.Id = this.id;
            this.evtTsvAltContr.ideEmpregador = this.t_ideEmpregador;
            this.evtTsvAltContr.ideEvento = this.t_ideEvento;
            this.evtTsvAltContr.ideTrabSemVinculo = this.t_ideSemVinculo;
            this.evtTsvAltContr.infoTSVAlteracao = this.infoTsvAlteracao;

            this.t_ideSemVinculo.matricula = this.matricula;
            this.t_ideSemVinculo.cpfTrab = this.cpfTrab;
            this.t_ideSemVinculo.codCateg = this.codCateg;

            this.t_ideEmpregador.nrInsc = this.nrInsc;
            this.t_ideEmpregador.tpInsc = this.tpInsc;

            this.infoTsvAlteracao.dtAlteracao = this.dtAlteracao;
            this.infoTsvAlteracao.infoComplementares = this.infoComplementares;

            this.infoComplementares.cargoFuncao = this.cargoFuncao;
            this.infoComplementares.remuneracao = this.remuneracao;
            this.infoComplementares.infoDirigenteSindical = this.infoDirigenteSindical;

            this.infoComplementares.infoTrabCedido = this.infoTrabCedido;
            this.infoComplementares.infoMandElet = this.infoMandElet;

            this.infoComplementares.infoEstagiario = this.infoEstagiario;
            this.infoEstagiario.instEnsino = this.instEnsino;
            this.infoEstagiario.ageIntegracao = this.ageIntegracao;
            this.infoEstagiario.supervisorEstagio = this.supervisorEstagio;

            XmlSerializer xml = new XmlSerializer(typeof(eSocialEvtTSVAltContr));
            xml.Serialize(Console.Out, evtTsvAltContr);
            Console.Read();
        }
        
    }
}
