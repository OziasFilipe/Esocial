using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using BibliotecaEsocial.Model.S5011;

namespace BibliotecaEsocial.Eventos.S5011
{
    class S5011
    {
        private eSocial eSocialEvt = new eSocial();
        private eSocialEvtCS evtCs = new eSocialEvtCS();
        private T_ideEmpregador t_ideEmpregador = new T_ideEmpregador();
        private T_ideEvento_retorno_contrib t_ideEvento = new T_ideEvento_retorno_contrib();
        private eSocialEvtCSInfoCS infoCs = new eSocialEvtCSInfoCS();
        private eSocialEvtCSInfoCSInfoCPSeg infoCpSeg = new eSocialEvtCSInfoCSInfoCPSeg();
        private eSocialEvtCSInfoCSInfoContrib infoContrib = new eSocialEvtCSInfoCSInfoContrib();
        private eSocialEvtCSInfoCSInfoContribInfoPJ infoPj = new eSocialEvtCSInfoCSInfoContribInfoPJ();

        private eSocialEvtCSInfoCSInfoContribInfoPJInfoAtConc infoAtConc =
            new eSocialEvtCSInfoCSInfoContribInfoPJInfoAtConc();

        private eSocialEvtCSInfoCSIdeEstab[] ideEstab = new eSocialEvtCSInfoCSIdeEstab[1];
        private eSocialEvtCSInfoCSIdeEstabInfoEstab infoEstab = new eSocialEvtCSInfoCSIdeEstabInfoEstab();
        private eSocialEvtCSInfoCSIdeEstabIdeLotacao[] ideLotacao = new eSocialEvtCSInfoCSIdeEstabIdeLotacao[1];

        private eSocialEvtCSInfoCSIdeEstabInfoEstabInfoEstabRef infoEstabRef =
            new eSocialEvtCSInfoCSIdeEstabInfoEstabInfoEstabRef();

        private eSocialEvtCSInfoCSIdeEstabInfoEstabInfoComplObra infoComplObra =
            new eSocialEvtCSInfoCSIdeEstabInfoEstabInfoComplObra();

        private eSocialEvtCSInfoCSIdeEstabIdeLotacaoInfoTercSusp[] infoTercSusp =
            new eSocialEvtCSInfoCSIdeEstabIdeLotacaoInfoTercSusp[1];

        private eSocialEvtCSInfoCSIdeEstabIdeLotacaoInfoEmprParcial infoEmprParcial =
            new eSocialEvtCSInfoCSIdeEstabIdeLotacaoInfoEmprParcial();

        private eSocialEvtCSInfoCSIdeEstabIdeLotacaoDadosOpPort dadosOpPort =
            new eSocialEvtCSInfoCSIdeEstabIdeLotacaoDadosOpPort();

        private eSocialEvtCSInfoCSIdeEstabIdeLotacaoBasesRemun[] basesRemun =
            new eSocialEvtCSInfoCSIdeEstabIdeLotacaoBasesRemun[1];

        private eSocialEvtCSInfoCSIdeEstabIdeLotacaoBasesRemunBasesCp basesCp =
            new eSocialEvtCSInfoCSIdeEstabIdeLotacaoBasesRemunBasesCp();

        private eSocialEvtCSInfoCSIdeEstabIdeLotacaoBasesAvNPort basesAvNPort =
            new eSocialEvtCSInfoCSIdeEstabIdeLotacaoBasesAvNPort();

        private eSocialEvtCSInfoCSIdeEstabIdeLotacaoInfoSubstPatrOpPort infoSubstPatrOpPort =
            new eSocialEvtCSInfoCSIdeEstabIdeLotacaoInfoSubstPatrOpPort();

        private eSocialEvtCSInfoCSIdeEstabBasesAquis[] basesAquis = new eSocialEvtCSInfoCSIdeEstabBasesAquis[1];
        private eSocialEvtCSInfoCSIdeEstabBasesComerc[] basesComerc = new eSocialEvtCSInfoCSIdeEstabBasesComerc[1];
        private eSocialEvtCSInfoCSIdeEstabInfoCREstab[] infoCreEstab = new eSocialEvtCSInfoCSIdeEstabInfoCREstab[1];
        private eSocialEvtCSInfoCSInfoCRContrib[] infoCrContrib = new eSocialEvtCSInfoCSInfoCRContrib[1];

        private string id = string.Empty;
        private string nrInsc = string.Empty;
        private string perApur = string.Empty;
        private sbyte tpInsc = 0;
        private sbyte indApuracao = 0;
        private sbyte tpInscEstab = 0;
        private string nrInscEstab = string.Empty;
        private string codLotacao = string.Empty;
        private string codTerc = string.Empty;
        private sbyte indIncid = 0;
        private string codCateg = string.Empty;
        private sbyte indAquis = 0;
        private sbyte indComerc = 0;
        private string tpCr1 = string.Empty;
        private string tpCr2 = string.Empty;


        public void s5011()
        {
            this.eSocialEvt.evtCS = this.evtCs;
            this.evtCs.Id = this.id;
            this.evtCs.ideEmpregador = this.t_ideEmpregador;
            this.evtCs.ideEvento = this.t_ideEvento;
            this.evtCs.infoCS = this.infoCs;

            this.t_ideEvento.perApur = this.perApur;
            this.t_ideEvento.indApuracao = this.indApuracao;

            this.t_ideEmpregador.nrInsc = this.nrInsc;
            this.t_ideEmpregador.tpInsc = this.tpInsc;

            this.infoCs.infoCPSeg =  this.infoCpSeg;
            this.infoCs.infoContrib = this.infoContrib;

            this.infoContrib.infoPJ = this.infoPj;

            this.infoPj.infoAtConc = this.infoAtConc;

            this.infoCs.ideEstab = this.ideEstab;

            this.ideEstab[0] = new eSocialEvtCSInfoCSIdeEstab();
            this.ideEstab[0].tpInsc = this.tpInscEstab;
            this.ideEstab[0].nrInsc = this.nrInscEstab;
            this.ideEstab[0].infoEstab = this.infoEstab;
            this.ideEstab[0].ideLotacao = this.ideLotacao;


            this.infoEstab.infoEstabRef = this.infoEstabRef;
            this.infoEstab.infoComplObra = this.infoComplObra;
           
            this.ideLotacao[0] = new eSocialEvtCSInfoCSIdeEstabIdeLotacao();
            this.ideLotacao[0].codLotacao = this.codLotacao;
            this.ideLotacao[0].infoTercSusp = this.infoTercSusp;

            this.infoTercSusp[0] = new eSocialEvtCSInfoCSIdeEstabIdeLotacaoInfoTercSusp();
            this.infoTercSusp[0].codTerc = this.codTerc;

            this.ideLotacao[0].infoEmprParcial = this.infoEmprParcial;
            this.ideLotacao[0].dadosOpPort = this.dadosOpPort;
            this.ideLotacao[0].basesRemun = this.basesRemun;

            this.basesRemun[0] = new eSocialEvtCSInfoCSIdeEstabIdeLotacaoBasesRemun();
            this.basesRemun[0].indIncid = this.indIncid;
            this.basesRemun[0].codCateg = this.codCateg;
            this.basesRemun[0].basesCp = this.basesCp;

            this.ideLotacao[0].basesAvNPort = this.basesAvNPort;
            this.ideLotacao[0].infoSubstPatrOpPort = this.infoSubstPatrOpPort;

            this.ideEstab[0].basesAquis = this.basesAquis;

            this.basesAquis[0] = new eSocialEvtCSInfoCSIdeEstabBasesAquis();
            this.basesAquis[0].indAquis = this.indAquis;

            this.ideEstab[0].basesComerc = this.basesComerc;

            this.basesComerc[0] = new eSocialEvtCSInfoCSIdeEstabBasesComerc();
            this.basesComerc[0].indComerc = this.indComerc;

            this.ideEstab[0].infoCREstab = this.infoCreEstab;

            this.infoCreEstab[0] = new eSocialEvtCSInfoCSIdeEstabInfoCREstab();
            this.infoCreEstab[0].tpCR = this.tpCr1;

            this.infoCs.infoCRContrib = this.infoCrContrib;

            this.infoCrContrib[0] = new eSocialEvtCSInfoCSInfoCRContrib();
            this.infoCrContrib[0].tpCR = this.tpCr2;

            XmlSerializer xml = new XmlSerializer(typeof(eSocial));
            xml.Serialize(Console.Out, eSocialEvt);
            Console.Read();
        }
    }
}
