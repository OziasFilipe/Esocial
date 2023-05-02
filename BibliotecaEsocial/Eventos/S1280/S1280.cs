using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using BibliotecaEsocial.Model.S1280;

namespace BibliotecaEsocial.Eventos.S1280
{
    class S1280
    {
        private eSocial eSocialEvt = new eSocial();
        private eSocialEvtInfoComplPer evtInfoComplPer = new eSocialEvtInfoComplPer();
        private T_ideEvento_folha t_ideEvento = new T_ideEvento_folha();
        private T_ideEmpregador t_ideEmpregador = new T_ideEmpregador();
        private eSocialEvtInfoComplPerInfoSubstPatr infoSubstPatr = new eSocialEvtInfoComplPerInfoSubstPatr();

        private eSocialEvtInfoComplPerInfoSubstPatrOpPort[] infoSubstPatrOp =
            new eSocialEvtInfoComplPerInfoSubstPatrOpPort[1];

        private eSocialEvtInfoComplPerInfoAtivConcom infoAtivConcom = new eSocialEvtInfoComplPerInfoAtivConcom();

        private eSocialEvtInfoComplPerInfoPercTransf11096 infoPercTransf11096 =
            new eSocialEvtInfoComplPerInfoPercTransf11096();
        private string id = string.Empty;
        private string perApur = string.Empty;
        private string nrInsc = string.Empty;
        private sbyte indGuia = 0;
        private sbyte tpInsc = 0;
        private sbyte indApuracao = 0;
        private string codLotacao = string.Empty;
        public void s1280()
        {
            this.eSocialEvt = this.eSocialEvt;
            this.eSocialEvt.evtInfoComplPer = this.evtInfoComplPer;

            this.evtInfoComplPer.Id = this.id;
            this.evtInfoComplPer.ideEvento = this.t_ideEvento;
            this.evtInfoComplPer.ideEmpregador = this.t_ideEmpregador;
            this.evtInfoComplPer.infoSubstPatr = this.infoSubstPatr;
            this.evtInfoComplPer.infoSubstPatrOpPort = this.infoSubstPatrOp;
            this.evtInfoComplPer.infoAtivConcom = this.infoAtivConcom;
            this.evtInfoComplPer.infoPercTransf11096 = this.infoPercTransf11096;

            this.t_ideEvento.perApur = this.perApur;
            this.t_ideEvento.indGuia = this.indGuia;
            this.t_ideEvento.indApuracao = this.indApuracao;

            this.t_ideEmpregador.nrInsc = this.nrInsc;
            this.t_ideEmpregador.tpInsc = this.tpInsc;

            this.infoSubstPatrOp[0] = new eSocialEvtInfoComplPerInfoSubstPatrOpPort();
            this.infoSubstPatrOp[0].codLotacao = this.codLotacao;

            XmlSerializer xml = new XmlSerializer(typeof(eSocial));
            xml.Serialize(Console.Out, eSocialEvt);
            Console.Read();

        }
    }
}
