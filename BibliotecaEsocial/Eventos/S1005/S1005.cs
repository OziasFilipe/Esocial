using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using BibliotecaEsocial.Model.S1005;

namespace BibliotecaEsocial.Eventos.S1005
{
    class S1005
    {
        private eSocialEvtTabEstab evtTabEstab = new eSocialEvtTabEstab();
        private eSocialEvtTabEstabInfoEstab infoEstab = new eSocialEvtTabEstabInfoEstab();
        private T_ideEmpregador t_ideEmpregador = new T_ideEmpregador();
        private T_ideEvento_evtTab_inicial t_ideEvento_evtTab_inicial = new T_ideEvento_evtTab_inicial();
        private eSocialEvtTabEstabInfoEstabInclusao inclusao = new eSocialEvtTabEstabInfoEstabInclusao();
        private T_ideEstab ideEstab = new T_ideEstab();
        private T_dadosEstab dadosEstab = new T_dadosEstab();
        private T_dadosEstabAliqGilrat aliqGilrat = new T_dadosEstabAliqGilrat();
        private T_dadosEstabAliqGilratProcAdmJudRat procAdmJudRat = new T_dadosEstabAliqGilratProcAdmJudRat();
        private T_dadosEstabAliqGilratProcAdmJudFap procAdmJudFap = new T_dadosEstabAliqGilratProcAdmJudFap();
        private T_dadosEstabInfoCaepf infoCaepf = new T_dadosEstabInfoCaepf();
        private T_dadosEstabInfoObra infoObra = new T_dadosEstabInfoObra();
        private T_dadosEstabInfoTrab infoTrab = new T_dadosEstabInfoTrab();
        private T_dadosEstabInfoTrabInfoApr infoApr = new T_dadosEstabInfoTrabInfoApr();
        private eSocialEvtTabEstabInfoEstabAlteracao alteracao = new eSocialEvtTabEstabInfoEstabAlteracao();
        private T_dadosEstabInfoTrabInfoAprInfoEntEduc[] infoEntEduc = new T_dadosEstabInfoTrabInfoAprInfoEntEduc[1];
        private T_dadosEstabInfoTrabInfoPCD infoPcd = new T_dadosEstabInfoTrabInfoPCD();
        private T_novaValidade novaValidade = new T_novaValidade();
        private eSocialEvtTabEstabInfoEstabExclusao exclusao = new eSocialEvtTabEstabInfoEstabExclusao();

        public string id = string.Empty;
        public string nrInsc = string.Empty;
        public sbyte tpInsc = 0;
        public sbyte procEmi = 0;
        public sbyte tpAmb = 0;
        public string verProc = string.Empty;
        public string nrInscIde = string.Empty;
        public string nrInscEnt = string.Empty;
        public string iniValid = string.Empty;
        public string fimValid = string.Empty;
        public sbyte tpInscIde = 0;

        // private object inclusao = new object();


        public void s1005()
        {
            this.evtTabEstab.Id = this.id;
            this.evtTabEstab.ideEmpregador = this.t_ideEmpregador;
            this.evtTabEstab.infoEstab = this.infoEstab;
            this.evtTabEstab.ideEvento = this.t_ideEvento_evtTab_inicial;

            this.t_ideEmpregador.nrInsc = this.nrInsc;
            this.t_ideEmpregador.tpInsc = this.tpInsc;

            this.infoEstab.inclusao = this.inclusao;
            this.inclusao.ideEstab = this.ideEstab;
            this.inclusao.dadosEstab = this.dadosEstab;

            this.ideEstab.tpInsc = this.tpInscIde;
            this.ideEstab.nrInsc = this.nrInscIde;
            this.ideEstab.iniValid = this.iniValid;
            this.ideEstab.fimValid = this.fimValid;

            this.dadosEstab.aliqGilrat = this.aliqGilrat;

            this.aliqGilrat.procAdmJudRat = this.procAdmJudRat;
            this.aliqGilrat.procAdmJudFap = this.procAdmJudFap;

            this.dadosEstab.infoCaepf = this.infoCaepf;
            this.dadosEstab.infoObra = this.infoObra;
            this.dadosEstab.infoTrab = this.infoTrab;

            this.infoTrab.infoApr = this.infoApr;

            this.infoApr.infoEntEduc = this.infoEntEduc;
            this.infoEntEduc[0] = new T_dadosEstabInfoTrabInfoAprInfoEntEduc();
            this.infoEntEduc[0].nrInsc = this.nrInscEnt;


            this.infoTrab.infoPCD = this.infoPcd;

            this.infoEstab.alteracao = this.alteracao;

            this.alteracao.ideEstab = this.ideEstab;
            this.alteracao.dadosEstab = this.dadosEstab;
            this.alteracao.novaValidade = this.novaValidade;

            this.infoEstab.exclusao = this.exclusao;
            this.exclusao.ideEstab = this.ideEstab;
            
            
            this.t_ideEvento_evtTab_inicial.procEmi = this.procEmi;
            this.t_ideEvento_evtTab_inicial.tpAmb = this.tpAmb;
            this.t_ideEvento_evtTab_inicial.verProc = this.verProc;

           XmlSerializer xmlSerializer = new XmlSerializer(typeof(eSocialEvtTabEstab));
           xmlSerializer.Serialize(Console.Out, evtTabEstab);
           Console.ReadLine();
        }

    }
}
