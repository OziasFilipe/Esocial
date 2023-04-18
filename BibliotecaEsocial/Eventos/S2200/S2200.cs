using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using BibliotecaEsocial.Model.S2200;
using BibliotecaEsocial.Validacao;

namespace BibliotecaEsocial.Eventos.S2200
{
    class S2200
    {
        private eSocial esocial = new eSocial();

        public eSocialEvtAdmissao evtAdmissao = new eSocialEvtAdmissao();
        public T_ideEmpregador t_ideEmpregador = new T_ideEmpregador(); 
        public T_ideEvento_trab_admissao t_ideEvento_trab_admissao = new T_ideEvento_trab_admissao();
        public eSocialEvtAdmissaoTrabalhador AdmissaoTrabalhador = new eSocialEvtAdmissaoTrabalhador();
        public eSocialEvtAdmissaoVinculo admissaoVinculo = new eSocialEvtAdmissaoVinculo();

        public  eSocialEvtAdmissaoTrabalhadorInfoDeficiencia admissaoTrabalhadorInfoDeficiencia = new eSocialEvtAdmissaoTrabalhadorInfoDeficiencia();
        public T_contato tContato= new T_contato();
        public eSocialEvtAdmissaoTrabalhadorDependente[] admissaoTrabalhadorDependente = new eSocialEvtAdmissaoTrabalhadorDependente[0];
        public eSocialEvtAdmissaoTrabalhadorTrabImig admissaoTrabalhadorTrabImig = new eSocialEvtAdmissaoTrabalhadorTrabImig();
        public eSocialEvtAdmissaoTrabalhadorEndereco admissaoTrabalhadorEndereco = new eSocialEvtAdmissaoTrabalhadorEndereco();
        public T_nascimento tNascimento = new T_nascimento();
        public eSocialEvtAdmissaoVinculoAfastamento admissaoVinculoAfastamento =  new eSocialEvtAdmissaoVinculoAfastamento();
        public eSocialEvtAdmissaoVinculoCessao admissaoVinculoCessao = new eSocialEvtAdmissaoVinculoCessao();
        public eSocialEvtAdmissaoVinculoDesligamento admissaoVinculoDesligamento = new eSocialEvtAdmissaoVinculoDesligamento();
        public eSocialEvtAdmissaoVinculoInfoContrato admissaoVinculoInfoContrato = new eSocialEvtAdmissaoVinculoInfoContrato();
        public eSocialEvtAdmissaoVinculoInfoRegimeTrab admissaoVinculoInfoRegimeTrab = new eSocialEvtAdmissaoVinculoInfoRegimeTrab();
        public eSocialEvtAdmissaoVinculoMudancaCPF admissaoVinculoMudancaCpf = new eSocialEvtAdmissaoVinculoMudancaCPF();
        public eSocialEvtAdmissaoVinculoSucessaoVinc adnuAdmissaoVinculoSucessaoVinc = new eSocialEvtAdmissaoVinculoSucessaoVinc();
        public eSocialEvtAdmissaoVinculoTransfDom admissaoVinculoTransfDom = new eSocialEvtAdmissaoVinculoTransfDom();

        public void S_2200()
        {
            this.evtAdmissao.Id = "";
            this.evtAdmissao.ideEmpregador = this.t_ideEmpregador; 
            this.evtAdmissao.ideEvento = this.t_ideEvento_trab_admissao;
            this.evtAdmissao.trabalhador = this.AdmissaoTrabalhador;
            this.evtAdmissao.vinculo = this.admissaoVinculo;

            this.t_ideEmpregador.nrInsc = "NULL";
            this.t_ideEmpregador.tpInsc = 0;

            this.t_ideEvento_trab_admissao.indRetif = 0;
            this.t_ideEvento_trab_admissao.nrRecibo = "";
            this.t_ideEvento_trab_admissao.procEmi = 0;
            this.t_ideEvento_trab_admissao.tpAmb = 0;
            this.t_ideEvento_trab_admissao.verProc = "";

            this.AdmissaoTrabalhador.infoDeficiencia = this.admissaoTrabalhadorInfoDeficiencia;
            this.AdmissaoTrabalhador.contato = this.tContato;
            this.AdmissaoTrabalhador.trabImig = this.admissaoTrabalhadorTrabImig;
            this.AdmissaoTrabalhador.cpfTrab = "";
            this.AdmissaoTrabalhador.sexo = TS_sexoTrab.F;
            this.AdmissaoTrabalhador.racaCor = 0;
            this.AdmissaoTrabalhador.dependente = this.admissaoTrabalhadorDependente;
            this.AdmissaoTrabalhador.endereco = this.admissaoTrabalhadorEndereco;
            this.AdmissaoTrabalhador.estCiv = 0;
            this.AdmissaoTrabalhador.estCivSpecified = true;
            this.AdmissaoTrabalhador.grauInstr = TS_grauInstr.Item01;
            this.AdmissaoTrabalhador.nascimento = this.tNascimento;
            this.AdmissaoTrabalhador.nmSoc = "";
            this.AdmissaoTrabalhador.nmTrab = "";

            this.admissaoVinculo.afastamento = this.admissaoVinculoAfastamento;
            this.admissaoVinculo.cessao = this.admissaoVinculoCessao;
            this.admissaoVinculo.cadIni = eSocialEvtAdmissaoVinculoCadIni.N;
            this.admissaoVinculo.desligamento = this.admissaoVinculoDesligamento;
            this.admissaoVinculo.infoContrato = this.admissaoVinculoInfoContrato;
            this.admissaoVinculo.infoRegimeTrab = this.admissaoVinculoInfoRegimeTrab;
            this.admissaoVinculo.matricula = "";
            this.admissaoVinculo.mudancaCPF = this.admissaoVinculoMudancaCpf;
            this.admissaoVinculo.sucessaoVinc = this.adnuAdmissaoVinculoSucessaoVinc;
            this.admissaoVinculo.tpRegPrev = 0;
            this.admissaoVinculo.tpRegTrab = 0;
            this.admissaoVinculo.transfDom = this.admissaoVinculoTransfDom;

            this.admissaoTrabalhadorInfoDeficiencia.defAuditiva = TS_defFisica.N;
            this.tContato.emailPrinc = "";
            this.tContato.fonePrinc = "";
          
            ;

            XmlSerializer xml = new XmlSerializer(typeof(eSocialEvtAdmissao));
            xml.Serialize(Console.Out, esocial);

            Console.ReadLine();

        }

       
    }   
}
