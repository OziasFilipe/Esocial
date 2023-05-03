using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using BibliotecaEsocial.Model.S2300;
using eSocial = BibliotecaEsocial.Model.S2300.eSocial;
using T_contato = BibliotecaEsocial.Model.S2300.T_contato;
using T_ideEmpregador = BibliotecaEsocial.Model.S2300.T_ideEmpregador;
using T_nascimento = BibliotecaEsocial.Model.S2300.T_nascimento;
using T_remuneracao = BibliotecaEsocial.Model.S2300.T_remuneracao;

namespace BibliotecaEsocial.Eventos.S2300
{
    class S2300
    {
        private eSocial eSocialEvt = new eSocial();
        private eSocialEvtTSVInicio evtTsvInicio = new eSocialEvtTSVInicio();
        private T_ideEmpregador t_ideEmpregador = new T_ideEmpregador();
        private T_ideEvento_trab t_ideEvento = new T_ideEvento_trab();
        private eSocialEvtTSVInicioTrabalhador trabalhador = new eSocialEvtTSVInicioTrabalhador();
        private T_nascimento nascimento = new T_nascimento();
        private eSocialEvtTSVInicioTrabalhadorEndereco endereco = new eSocialEvtTSVInicioTrabalhadorEndereco();
        private eSocialEvtTSVInicioTrabalhadorTrabImig trabImig = new eSocialEvtTSVInicioTrabalhadorTrabImig();

        private eSocialEvtTSVInicioTrabalhadorInfoDeficiencia infoDeficiencia =
            new eSocialEvtTSVInicioTrabalhadorInfoDeficiencia();

        private eSocialEvtTSVInicioTrabalhadorDependente[] dependente = new eSocialEvtTSVInicioTrabalhadorDependente[1];
        private T_contato contato = new T_contato();
        private eSocialEvtTSVInicioInfoTSVInicio infoTsvInicio = new eSocialEvtTSVInicioInfoTSVInicio();

        private eSocialEvtTSVInicioInfoTSVInicioInfoComplementares infoComplementares =
            new eSocialEvtTSVInicioInfoTSVInicioInfoComplementares();

        private eSocialEvtTSVInicioInfoTSVInicioInfoComplementaresCargoFuncao cargoFuncao =
            new eSocialEvtTSVInicioInfoTSVInicioInfoComplementaresCargoFuncao();

        private T_remuneracao remuneracao = new T_remuneracao();

        private eSocialEvtTSVInicioInfoTSVInicioInfoComplementaresFGTS fgts =
            new eSocialEvtTSVInicioInfoTSVInicioInfoComplementaresFGTS();

        private eSocialEvtTSVInicioInfoTSVInicioInfoComplementaresInfoDirigenteSindical infoDirigenteSindical =
            new eSocialEvtTSVInicioInfoTSVInicioInfoComplementaresInfoDirigenteSindical();

        private eSocialEvtTSVInicioInfoTSVInicioInfoComplementaresInfoTrabCedido infoTrabCedido =
            new eSocialEvtTSVInicioInfoTSVInicioInfoComplementaresInfoTrabCedido();

        private eSocialEvtTSVInicioInfoTSVInicioInfoComplementaresInfoMandElet infoMandElet =
            new eSocialEvtTSVInicioInfoTSVInicioInfoComplementaresInfoMandElet();

        private T_infoEstagiario infoEstagiario = new T_infoEstagiario();
        private T_infoEstagiarioInstEnsino instEnsino = new T_infoEstagiarioInstEnsino();
        private T_infoEstagiarioAgeIntegracao ageIntegracao = new T_infoEstagiarioAgeIntegracao();
        private T_infoEstagiarioSupervisorEstagio supervisorEstagio = new T_infoEstagiarioSupervisorEstagio();

        private eSocialEvtTSVInicioInfoTSVInicioMudancaCPF
            mudancaCpf = new eSocialEvtTSVInicioInfoTSVInicioMudancaCPF();

        private eSocialEvtTSVInicioInfoTSVInicioAfastamento afastamento =
            new eSocialEvtTSVInicioInfoTSVInicioAfastamento();

        private eSocialEvtTSVInicioInfoTSVInicioTermino termino = new eSocialEvtTSVInicioInfoTSVInicioTermino();

       

        private string id = string.Empty;
        private string nrInsc = string.Empty;
        private sbyte tpInsc = 0;
        private string cpfTrab = string.Empty;
        private object brasil = new object();
        private object exterior = new object();
        private string tpDep = string.Empty;
        private string nmDep = string.Empty;
        private DateTime dtNascto = DateTime.Now;
        private string matricula = string.Empty;
        private string codCateg = string.Empty;
        private DateTime dtInicio = DateTime.Now;


        public void s2300()
        {
            this.eSocialEvt = this.eSocialEvt;
            this.eSocialEvt.evtTSVInicio = this.evtTsvInicio;
            this.evtTsvInicio.Id = this.id;
            this.evtTsvInicio.ideEmpregador = this.t_ideEmpregador;
            this.evtTsvInicio.ideEvento = this.t_ideEvento;

            this.t_ideEmpregador.nrInsc = this.nrInsc;
            this.t_ideEmpregador.tpInsc = this.tpInsc;

            this.evtTsvInicio.trabalhador = this.trabalhador;
            this.trabalhador.cpfTrab = this.cpfTrab;
            this.trabalhador.nascimento = this.nascimento;
            this.trabalhador.endereco = this.endereco;
            this.endereco.brasil = this.brasil;
            this.endereco.exterior = this.exterior;
            this.trabalhador.trabImig = this.trabImig;
            this.trabalhador.infoDeficiencia = this.infoDeficiencia;
            this.dependente[0] = new eSocialEvtTSVInicioTrabalhadorDependente();
            this.dependente[0].tpDep = this.tpDep;
            this.dependente[0].nmDep = this.nmDep;
            this.dependente[0].dtNascto = this.dtNascto;

            this.trabalhador.contato = this.contato;
            this.evtTsvInicio.infoTSVInicio = this.infoTsvInicio;

            this.infoTsvInicio.matricula = this.matricula;
            this.infoTsvInicio.codCateg = this.codCateg;
            this.infoTsvInicio.dtInicio = this.dtInicio;

            this.infoTsvInicio.infoComplementares = this.infoComplementares;

            this.infoComplementares.cargoFuncao = this.cargoFuncao;
            this.infoComplementares.remuneracao = this.remuneracao;
            this.infoComplementares.FGTS = this.fgts;
            this.infoComplementares.infoDirigenteSindical =
                this.infoDirigenteSindical;

            this.infoComplementares.infoTrabCedido =
                this.infoTrabCedido;
            this.infoComplementares.infoMandElet = this.infoMandElet;
            this.infoComplementares.infoEstagiario = this.infoEstagiario;
            this.infoEstagiario.instEnsino = this.instEnsino;
            this.infoEstagiario.ageIntegracao = this.ageIntegracao;
            this.infoEstagiario.supervisorEstagio = this.supervisorEstagio;

            this.infoTsvInicio.mudancaCPF = this.mudancaCpf;
            this.infoTsvInicio.afastamento = this.afastamento;
            this.infoTsvInicio.termino = this.termino;



            XmlSerializer xml = new XmlSerializer(typeof(eSocial));
            xml.Serialize(Console.Out, eSocialEvt);
            Console.ReadLine();

        }
    }
}
