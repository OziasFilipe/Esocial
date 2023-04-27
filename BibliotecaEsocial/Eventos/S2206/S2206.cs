using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using BibliotecaEsocial.Model.S2206;

namespace BibliotecaEsocial.Eventos.S2206
{
    class S2206
    {
        private eSocialEvtAltContratual evtAltContratual = new eSocialEvtAltContratual();
        private T_ideEvento_trab t_ideEvento = new T_ideEvento_trab();
        private eSocialEvtAltContratualAltContratual altContratual = new eSocialEvtAltContratualAltContratual();
        private T_ideEmpregador t_ideEmpregador = new T_ideEmpregador();
        private T_ideVinculo t_ideVinculo = new T_ideVinculo();

        private eSocialEvtAltContratualAltContratualVinculo evtVinculo =
            new eSocialEvtAltContratualAltContratualVinculo();

        private eSocialEvtAltContratualAltContratualVinculoInfoRegimeTrab infoRegimeTrab =
            new eSocialEvtAltContratualAltContratualVinculoInfoRegimeTrab();

        private eSocialEvtAltContratualAltContratualVinculoInfoRegimeTrabInfoCeletista infoCeletista =
            new eSocialEvtAltContratualAltContratualVinculoInfoRegimeTrabInfoCeletista();

        private eSocialEvtAltContratualAltContratualVinculoInfoRegimeTrabInfoCeletistaTrabTemporario trabTemporario =
            new eSocialEvtAltContratualAltContratualVinculoInfoRegimeTrabInfoCeletistaTrabTemporario();

        private T_aprend aprend = new T_aprend();

        private eSocialEvtAltContratualAltContratualVinculoInfoRegimeTrabInfoEstatutario infoEstatutario =
            new eSocialEvtAltContratualAltContratualVinculoInfoRegimeTrabInfoEstatutario();

        private eSocialEvtAltContratualAltContratualVinculoInfoContrato infoContrato =
            new eSocialEvtAltContratualAltContratualVinculoInfoContrato();

        private T_remuneracao remuneracao = new T_remuneracao();

        private eSocialEvtAltContratualAltContratualVinculoInfoContratoDuracao duracao =
            new eSocialEvtAltContratualAltContratualVinculoInfoContratoDuracao();

        private eSocialEvtAltContratualAltContratualVinculoInfoContratoLocalTrabalho localTrabalho =
            new eSocialEvtAltContratualAltContratualVinculoInfoContratoLocalTrabalho();

        private T_localTrabGeral localTrabGeral = new T_localTrabGeral();
        private T_endereco_brasil localTempDom = new T_endereco_brasil();
        private T_horContratual horContratual = new T_horContratual();
        private T_alvaraJudicial alvaraJudicial = new T_alvaraJudicial();

        private eSocialEvtAltContratualAltContratualVinculoInfoContratoObservacoes[] observacoes =
            new eSocialEvtAltContratualAltContratualVinculoInfoContratoObservacoes[0];

        private T_treiCap[] treiCap = new T_treiCap[0];


        private string id = string.Empty;
        private string nrInsc = string.Empty;
        private string cpfTrab = string.Empty;
        private string matricula = string.Empty;
        private string nrRecibo = string.Empty;
        private string dscAlt = string.Empty;
        private string verProc = string.Empty
            ;
        private DateTime dtEf = DateTime.Now;
        private DateTime dtAlteracao = DateTime.Now;
        
        private bool dtEfSpecified = false;
        
        private sbyte tpInsc = 0;
        private sbyte tpAmb = 0;
        private sbyte procEmi = 0;
        private sbyte indRetif = 0;



        public void s2206()
        {
            this.evtAltContratual.ideEvento = this.t_ideEvento;
            this.evtAltContratual.altContratual = this.altContratual;
            this.evtAltContratual.ideEmpregador = this.t_ideEmpregador;
            this.evtAltContratual.ideVinculo = this.t_ideVinculo;
            this.evtAltContratual.Id = this.id;

            this.altContratual.vinculo = this.evtVinculo;
            this.altContratual.dtAlteracao = this.dtAlteracao;
            this.altContratual.dtEf = this.dtEf;
            this.altContratual.dscAlt = this.dscAlt;
            this.altContratual.dtEfSpecified = this.dtEfSpecified;

            this.t_ideEmpregador.nrInsc = this.nrInsc;
            this.t_ideEmpregador.tpInsc = this.tpInsc;

            this.t_ideVinculo.cpfTrab = this.cpfTrab;
            this.t_ideVinculo.matricula = this.matricula;

            this.t_ideEvento.verProc = this.verProc;
            this.t_ideEvento.tpAmb = this.tpAmb;
            this.t_ideEvento.procEmi = this.procEmi;
            this.t_ideEvento.indRetif = this.indRetif;
            this.t_ideEvento.nrRecibo = this.nrRecibo;

            this.evtVinculo.infoRegimeTrab = this.infoRegimeTrab;
            this.evtVinculo.infoContrato = this.infoContrato;

            this.infoRegimeTrab.infoCeletista = this.infoCeletista;
            this.infoRegimeTrab.infoEstatutario = this.infoEstatutario;

            this.infoCeletista.trabTemporario = this.trabTemporario;
            this.infoCeletista.aprend = this.aprend;

            this.infoContrato.remuneracao = this.remuneracao;
            this.infoContrato.duracao = this.duracao;

            this.localTrabalho.localTrabGeral = this.localTrabGeral;
            this.localTrabalho.localTempDom = this.localTempDom;

            this.infoContrato.localTrabalho = this.localTrabalho;
            this.infoContrato.horContratual = this.horContratual;
            this.infoContrato.alvaraJudicial = this.alvaraJudicial;
            this.infoContrato.observacoes = this.observacoes;
            this.infoContrato.treiCap = this.treiCap;

            XmlSerializer xml = new XmlSerializer(typeof(eSocialEvtAltContratual));
            xml.Serialize(Console.Out, evtAltContratual);
            Console.ReadLine();


        }
    }
}
