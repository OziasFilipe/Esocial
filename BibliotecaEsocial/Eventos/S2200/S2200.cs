using System;
using System.Xml.Serialization;
using BibliotecaEsocial.Model.S2200;

namespace BibliotecaEsocial.Eventos.S2200
{
    class S2200
    {
        private eSocial esocial = new eSocial();
        private eSocialEvtAdmissao evtAdmissao = new eSocialEvtAdmissao();
        private T_ideEmpregador t_ideEmpregador = new T_ideEmpregador();
        private T_ideEvento_trab_admissao t_ideEvento_trab_admissao = new T_ideEvento_trab_admissao();
        private eSocialEvtAdmissaoTrabalhador AdmissaoTrabalhador = new eSocialEvtAdmissaoTrabalhador();
        private eSocialEvtAdmissaoVinculo admissaoVinculo = new eSocialEvtAdmissaoVinculo();
        private eSocialEvtAdmissaoTrabalhadorInfoDeficiencia admissaoTrabalhadorInfoDeficiencia = new eSocialEvtAdmissaoTrabalhadorInfoDeficiencia();
        private T_contato tContato = new T_contato();
        private eSocialEvtAdmissaoTrabalhadorDependente[] admissaoTrabalhadorDependente = new eSocialEvtAdmissaoTrabalhadorDependente[0];
        private eSocialEvtAdmissaoTrabalhadorTrabImig admissaoTrabalhadorTrabImig = new eSocialEvtAdmissaoTrabalhadorTrabImig();
        private eSocialEvtAdmissaoTrabalhadorEndereco admissaoTrabalhadorEndereco = new eSocialEvtAdmissaoTrabalhadorEndereco();
        private T_nascimento tNascimento = new T_nascimento();
        private eSocialEvtAdmissaoVinculoAfastamento admissaoVinculoAfastamento = new eSocialEvtAdmissaoVinculoAfastamento();
        private eSocialEvtAdmissaoVinculoCessao admissaoVinculoCessao = new eSocialEvtAdmissaoVinculoCessao();
        private eSocialEvtAdmissaoVinculoDesligamento admissaoVinculoDesligamento = new eSocialEvtAdmissaoVinculoDesligamento();
        private eSocialEvtAdmissaoVinculoInfoContrato admissaoVinculoInfoContrato = new eSocialEvtAdmissaoVinculoInfoContrato();
        private eSocialEvtAdmissaoVinculoInfoRegimeTrab admissaoVinculoInfoRegimeTrab = new eSocialEvtAdmissaoVinculoInfoRegimeTrab();
        private eSocialEvtAdmissaoVinculoMudancaCPF admissaoVinculoMudancaCpf = new eSocialEvtAdmissaoVinculoMudancaCPF();
        private eSocialEvtAdmissaoVinculoSucessaoVinc adnuAdmissaoVinculoSucessaoVinc = new eSocialEvtAdmissaoVinculoSucessaoVinc();
        private eSocialEvtAdmissaoVinculoTransfDom admissaoVinculoTransfDom = new eSocialEvtAdmissaoVinculoTransfDom();

        public string id = "";
        public string nrInsc = "";
        public sbyte tpInsc = 0;
        public sbyte indRetif = 0;
        public string nrRecibo = "";
        public sbyte procEmi = 0;
        public sbyte tpAmb = 0;
        public string verProc = "";
        public bool estCivSpecified = true;

        public void S_2200()
        {
            this.evtAdmissao.Id = this.id;
            this.evtAdmissao.ideEmpregador = this.t_ideEmpregador;
            this.evtAdmissao.ideEvento = this.t_ideEvento_trab_admissao;
            this.evtAdmissao.trabalhador = this.AdmissaoTrabalhador;
            this.evtAdmissao.vinculo = this.admissaoVinculo;

            this.t_ideEmpregador.nrInsc = this.nrInsc;
            this.t_ideEmpregador.tpInsc = this.tpInsc;

            this.t_ideEvento_trab_admissao.indRetif = this.indRetif;
            this.t_ideEvento_trab_admissao.nrRecibo = this.nrRecibo;
            this.t_ideEvento_trab_admissao.procEmi = this.procEmi;
            this.t_ideEvento_trab_admissao.tpAmb = this.tpAmb;
            this.t_ideEvento_trab_admissao.verProc = this.verProc;

            this.AdmissaoTrabalhador.trabImig = admissaoTrabalhadorTrabImig;
            this.AdmissaoTrabalhador.contato = tContato;
            this.AdmissaoTrabalhador.cpfTrab = "";
            //Elemento Array - Criar uma instancia referente a uma coleção
            //this.AdmissaoTrabalhador.dependente = new eSocialEvtAdmissaoTrabalhadorDependente();

            this.AdmissaoTrabalhador.endereco = new eSocialEvtAdmissaoTrabalhadorEndereco();
            this.AdmissaoTrabalhador.estCivSpecified = true;
            this.AdmissaoTrabalhador.grauInstr = TS_grauInstr.Item01;
            this.AdmissaoTrabalhador.infoDeficiencia = admissaoTrabalhadorInfoDeficiencia;
            this.AdmissaoTrabalhador.nascimento = tNascimento;
            this.AdmissaoTrabalhador.nmSoc = "";
            this.AdmissaoTrabalhador.racaCor = sbyte.MaxValue;
            this.AdmissaoTrabalhador.sexo = TS_sexoTrab.M;
            
           


            
            XmlSerializer xml = new XmlSerializer(typeof(eSocialEvtAdmissao));
            xml.Serialize(Console.Out, esocial);

            Console.ReadLine();

        }


    }
}
