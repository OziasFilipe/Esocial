using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using BibliotecaEsocial.ClassesEsquemas.S2230;

namespace BibliotecaEsocial.Eventos.S2230
{
    class S2230
    {

        public eSocial esocial = new eSocial();
        public eSocialEvtAfastTemp EvtAfastTemp = new eSocialEvtAfastTemp();
        public T_ideEmpregador IdeEmpregador = new T_ideEmpregador();
        public T_ideEvento_trab IdeEventoTrab = new T_ideEvento_trab();
        public eSocialEvtAfastTempInfoAfastamento ESocialEvtAfastTempInfoAfastamento = new eSocialEvtAfastTempInfoAfastamento();
        public eSocialEvtAfastTempIdeVinculo EvtAfastTempIdeVinculo = new eSocialEvtAfastTempIdeVinculo();
        public void s2230()
        {
            EvtAfastTemp.Id = "";
            EvtAfastTemp.ideEmpregador = IdeEmpregador;
            EvtAfastTemp.ideEvento = IdeEventoTrab;
            EvtAfastTemp.ideVinculo = EvtAfastTempIdeVinculo;
            EvtAfastTemp.infoAfastamento = ESocialEvtAfastTempInfoAfastamento;


                
            XmlSerializer xml = new XmlSerializer(typeof(eSocialEvtAfastTemp));
            xml.Serialize(Console.Out, EvtAfastTemp);

            Console.ReadLine();
        }
    }
}
