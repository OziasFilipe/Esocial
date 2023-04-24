using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using BibliotecaEsocial.Model.S2210;

namespace BibliotecaEsocial.Eventos.S2210
{
    class S2210
    {
        private eSocialEvtCAT evtCAT = new eSocialEvtCAT();
        private eSocialEvtCATCat cat = new eSocialEvtCATCat();
        private T_ideEmpregador t_ideEmpregador = new T_ideEmpregador();
        private T_ideEvento_trab t_ideEvento_trab = new T_ideEvento_trab();
        private T_ideVinculo_sst t_ideVinculo_sst = new T_ideVinculo_sst();
        private eSocialEvtCATCatAgenteCausador agenteCausador = new eSocialEvtCATCatAgenteCausador();
        private eSocialEvtCATCatAtestado atestado = new eSocialEvtCATCatAtestado();
        private eSocialEvtCATCatCatOrigem catOrigem = new eSocialEvtCATCatCatOrigem();
        private eSocialEvtCATCatLocalAcidente localAcidente = new eSocialEvtCATCatLocalAcidente();
        private eSocialEvtCATCatParteAtingida pareAtingida = new eSocialEvtCATCatParteAtingida();
        private eSocialEvtCATCatAtestadoEmitente emitente = new eSocialEvtCATCatAtestadoEmitente();


        private string id = string.Empty;
        private string nrInsc = string.Empty;
        private string matricula = string.Empty;
        private string codCateg = string.Empty;
        private string cpfTrab = string.Empty;
        private sbyte tpInsc = 0;
        private string codSitGeradora = string.Empty;
        private string hrAcid = string.Empty;
        private string hrsTrabAntesAcid = string.Empty;
        private string obsCAT = string.Empty;
        private DateTime dtAcid = DateTime.Now;
        private DateTime dtObito = DateTime.Now;
        private DateTime ultDiaTrab = DateTime.Now;
        private TS_sim_nao houveAfast = TS_sim_nao.N;
        private TS_sim_nao indCatObito = TS_sim_nao.N;
        private TS_sim_nao indComunPolicia = TS_sim_nao.N;
        private bool dtObitoSpecified = false;
        private bool houveAfastSpecified = false;
        private sbyte iniciatCAT = 0;
        private sbyte tpAcid = 0;




        public void s2210()
        {
            this.evtCAT.Id = this.id;
            this.evtCAT.cat = this.cat;
            this.evtCAT.ideEmpregador = this.t_ideEmpregador;
            this.evtCAT.ideEvento = this.t_ideEvento_trab;
            this.evtCAT.ideVinculo = this.t_ideVinculo_sst;

            this.t_ideEmpregador.nrInsc = this.nrInsc;
            this.t_ideEmpregador.tpInsc = this.tpInsc;

            this.t_ideVinculo_sst.matricula = this.matricula;
            this.t_ideVinculo_sst.codCateg = this.codCateg;
            this.t_ideVinculo_sst.cpfTrab = this.cpfTrab;

            this.cat.agenteCausador = this.agenteCausador;
            this.cat.atestado = this.atestado;
            this.cat.catOrigem = this.catOrigem;
            this.cat.codSitGeradora = this.codSitGeradora;
            this.cat.dtAcid = this.dtAcid;
            this.cat.dtObito = this.dtObito;
            this.cat.dtObitoSpecified = this.dtObitoSpecified;
            this.cat.houveAfast = this.houveAfast;
            this.cat.houveAfastSpecified = this.houveAfastSpecified;
            this.cat.hrAcid = this.hrAcid;
            this.cat.hrsTrabAntesAcid = this.hrsTrabAntesAcid;
            this.cat.indCatObito = this.indCatObito;
            this.cat.indComunPolicia = this.indComunPolicia;
            this.cat.iniciatCAT = this.iniciatCAT;
            this.cat.localAcidente = this.localAcidente;
            this.cat.obsCAT = this.obsCAT;
            this.cat.parteAtingida = this.pareAtingida;
            this.cat.tpAcid = this.tpAcid;
            this.cat.ultDiaTrab = this.ultDiaTrab;

            this.atestado.emitente = this.emitente;

            XmlSerializer xml = new XmlSerializer(typeof(eSocialEvtCAT));
            xml.Serialize(Console.Out, evtCAT);
            Console.Read();
        }

    }
}
