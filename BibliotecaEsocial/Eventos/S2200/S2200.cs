using System;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;
using BibliotecaEsocial.Model.S2200;

namespace BibliotecaEsocial.Eventos.S2200
{
    class S2200
    {
        private eSocial eSocialEvt = new eSocial();
        private eSocialEvtAdmissao evtAdmissao = new eSocialEvtAdmissao();
        private T_ideEmpregador t_ideEmpregador = new T_ideEmpregador();
        private T_ideEvento_trab_admissao t_ideEvento = new T_ideEvento_trab_admissao();
        private eSocialEvtAdmissaoTrabalhador trabalhador = new eSocialEvtAdmissaoTrabalhador();
        private T_nascimento nascimento = new T_nascimento();
        private eSocialEvtAdmissaoTrabalhadorEndereco endereco = new eSocialEvtAdmissaoTrabalhadorEndereco();
        private eSocialEvtAdmissaoTrabalhadorTrabImig trabImig = new eSocialEvtAdmissaoTrabalhadorTrabImig();

        private eSocialEvtAdmissaoTrabalhadorInfoDeficiencia infoDeficiencia =
            new eSocialEvtAdmissaoTrabalhadorInfoDeficiencia();

        private eSocialEvtAdmissaoTrabalhadorDependente[] dependentes = new eSocialEvtAdmissaoTrabalhadorDependente[1];
        private T_contato contato = new T_contato();
        private eSocialEvtAdmissaoVinculo vinculo = new eSocialEvtAdmissaoVinculo();
        private eSocialEvtAdmissaoVinculoInfoRegimeTrab infoRegimeTrab = new eSocialEvtAdmissaoVinculoInfoRegimeTrab();
        private eSocialEvtAdmissaoVinculoInfoRegimeTrabInfoCeletista infoCeletista =
            new eSocialEvtAdmissaoVinculoInfoRegimeTrabInfoCeletista();

        private eSocialEvtAdmissaoVinculoInfoRegimeTrabInfoEstatutario infoEstatutario =
            new eSocialEvtAdmissaoVinculoInfoRegimeTrabInfoEstatutario();

        private eSocialEvtAdmissaoVinculoInfoRegimeTrabInfoCeletistaFGTS fgts =
            new eSocialEvtAdmissaoVinculoInfoRegimeTrabInfoCeletistaFGTS();

        private eSocialEvtAdmissaoVinculoInfoRegimeTrabInfoCeletistaTrabTemporario trabTemporario =
            new eSocialEvtAdmissaoVinculoInfoRegimeTrabInfoCeletistaTrabTemporario();

        private eSocialEvtAdmissaoVinculoInfoRegimeTrabInfoCeletistaTrabTemporarioIdeEstabVinc ideEstabVinc =
            new eSocialEvtAdmissaoVinculoInfoRegimeTrabInfoCeletistaTrabTemporarioIdeEstabVinc();

        private eSocialEvtAdmissaoVinculoInfoRegimeTrabInfoCeletistaTrabTemporarioIdeTrabSubstituido[]
            ideTrabSubstituido =
                new eSocialEvtAdmissaoVinculoInfoRegimeTrabInfoCeletistaTrabTemporarioIdeTrabSubstituido[1];

        private T_aprend aprend = new T_aprend();
        private eSocialEvtAdmissaoVinculoInfoContrato infoContrato = new eSocialEvtAdmissaoVinculoInfoContrato();
        private T_remuneracao remuneracao = new T_remuneracao();

        private eSocialEvtAdmissaoVinculoInfoContratoDuracao duracao =
            new eSocialEvtAdmissaoVinculoInfoContratoDuracao();

        private eSocialEvtAdmissaoVinculoInfoContratoLocalTrabalho localTrabalho =
            new eSocialEvtAdmissaoVinculoInfoContratoLocalTrabalho();

        private T_localTrabGeral localTrabGeral = new T_localTrabGeral();
        private T_endereco_brasil localTrabDom = new T_endereco_brasil();
        private T_horContratual horContratual = new T_horContratual();
        private T_alvaraJudicial alvaraJudicial = new T_alvaraJudicial();

        private eSocialEvtAdmissaoVinculoInfoContratoObservacoes[] observacoes =
            new eSocialEvtAdmissaoVinculoInfoContratoObservacoes[1];

        private T_treiCap[] treiCap = new T_treiCap[1];
        private eSocialEvtAdmissaoVinculoSucessaoVinc sucessaoVinc = new eSocialEvtAdmissaoVinculoSucessaoVinc();
        private eSocialEvtAdmissaoVinculoTransfDom transfDom = new eSocialEvtAdmissaoVinculoTransfDom();
        private eSocialEvtAdmissaoVinculoMudancaCPF mudancaCpf = new eSocialEvtAdmissaoVinculoMudancaCPF();
        private eSocialEvtAdmissaoVinculoAfastamento afastamento = new eSocialEvtAdmissaoVinculoAfastamento();
        private eSocialEvtAdmissaoVinculoDesligamento desligamento = new eSocialEvtAdmissaoVinculoDesligamento();
        private eSocialEvtAdmissaoVinculoCessao cessao = new eSocialEvtAdmissaoVinculoCessao();

        public string id = string.Empty;
        public string nrInsc = string.Empty;
        public sbyte tpInsc = 0;
        public sbyte indRetif = 0;
        public string nrRecibo = string.Empty;
        public sbyte procEmi = 0;
        public sbyte tpAmb = 0;
        public string verProc = string.Empty;
        public bool estCivSpecified = true;
        public string cpfTrab = string.Empty;
        public object brasil = new object();
        public object exterior = new object();
        public string tpDep = string.Empty;
        public string nmDep = string.Empty;
        public DateTime dtNascto = DateTime.Now;
        public string matricula = string.Empty;
        public string cpfTrabSubst = string.Empty;
        public string codTreiCap = string.Empty;


        public void s2200()
        {
            this.eSocialEvt = this.eSocialEvt;
            this.eSocialEvt.evtAdmissao = this.evtAdmissao;

            this.evtAdmissao.Id = this.id;
            this.evtAdmissao.ideEmpregador = this.t_ideEmpregador;
            this.evtAdmissao.ideEvento = this.t_ideEvento;
            this.evtAdmissao.trabalhador = this.trabalhador;
            

            this.t_ideEmpregador.nrInsc = this.nrInsc;
            this.t_ideEmpregador.tpInsc = this.tpInsc;

            this.t_ideEvento.indRetif = this.indRetif;
            this.t_ideEvento.nrRecibo = this.nrRecibo;
            this.t_ideEvento.procEmi = this.procEmi;
            this.t_ideEvento.tpAmb = this.tpAmb;
            this.t_ideEvento.verProc = this.verProc;

            this.trabalhador.cpfTrab = this.cpfTrab;
            this.trabalhador.nascimento = this.nascimento;
            this.trabalhador.endereco = this.endereco;

            this.endereco.brasil = this.brasil;
            this.endereco.exterior = this.exterior;

            this.trabalhador.trabImig = this.trabImig;
            this.trabalhador.infoDeficiencia = this.infoDeficiencia;
            this.trabalhador.dependente = this.dependentes;
            this.trabalhador.contato = this.contato;

            this.dependentes[0] = new eSocialEvtAdmissaoTrabalhadorDependente();
            this.dependentes[0].tpDep = this.tpDep;
            this.dependentes[0].nmDep= this.nmDep;
            this.dependentes[0].dtNascto= this.dtNascto;

            this.evtAdmissao.vinculo = this.vinculo;

            this.vinculo.matricula = this.matricula;
            this.vinculo.infoRegimeTrab = this.infoRegimeTrab;

            this.infoRegimeTrab.infoCeletista = this.infoCeletista;

            this.infoCeletista.FGTS = this.fgts;
            this.infoCeletista.trabTemporario = this.trabTemporario;

            this.trabTemporario.ideEstabVinc = this.ideEstabVinc;
            this.trabTemporario.ideTrabSubstituido = this.ideTrabSubstituido;

            this.ideTrabSubstituido[0] =
                new eSocialEvtAdmissaoVinculoInfoRegimeTrabInfoCeletistaTrabTemporarioIdeTrabSubstituido();
            this.ideTrabSubstituido[0].cpfTrabSubst = this.cpfTrabSubst;

            this.infoCeletista.aprend = this.aprend;

            this.infoRegimeTrab.infoEstatutario = this.infoEstatutario;

            this.vinculo.infoContrato = this.infoContrato;

            this.infoContrato.remuneracao = this.remuneracao;
            this.infoContrato.duracao = this.duracao;
            this.infoContrato.localTrabalho = this.localTrabalho;

            this.localTrabalho.localTrabGeral = this.localTrabGeral;
            this.localTrabalho.localTempDom = this.localTrabDom;

            this.infoContrato.horContratual = this.horContratual;
            this.infoContrato.alvaraJudicial = this.alvaraJudicial;
            this.infoContrato.observacoes = this.observacoes;
            this.infoContrato.treiCap = this.treiCap;

            this.treiCap[0] = new T_treiCap();
            this.treiCap[0].codTreiCap = this.codTreiCap;

            this.vinculo.sucessaoVinc = this.sucessaoVinc;
            this.vinculo.transfDom = this.transfDom;
            this.vinculo.mudancaCPF = this.mudancaCpf;
            this.vinculo.afastamento = this.afastamento;
            this.vinculo.desligamento = this.desligamento;
            this.vinculo.cessao = this.cessao;

            XmlSerializer xml = new XmlSerializer(typeof(eSocial));
            xml.Serialize(Console.Out, eSocialEvt);
            Console.ReadLine();

        }


    }
}
