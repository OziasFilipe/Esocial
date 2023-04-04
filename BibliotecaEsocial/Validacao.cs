using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Schema;
using System.Xml.Serialization;

namespace BibliotecaEsocial

{
public class Validacao
{
    //private eSocialEvtTabEstab eSocialEvtTabEvtTabEstab = new eSocialEvtTabEstab();

        public string GerarXml()
        {
           // XmlSerializer xml = new XmlSerializer(typeof(eSocial));
           // xml.Serialize(Console.Out,esocial);
            return "";  
        }

        public  string Validate(string nomeXml , string uriXml, string caminhoEsquema)
        {
            // Carrega o arquivo de esquema XSD
            XmlSchemaSet schemaSet = new XmlSchemaSet();
            schemaSet.Add(null, "C:\\Users\\Tecsoluti\\Desktop\\Esocial Oficial\\BibliotecaEsocial\\BibliotecaEsocial\\EsquemasXSD\\PacoteXSD\\evtAdmissao.xsd");
            schemaSet.Compile();

            // Cria o documento XML a partir do esquema
            XmlDocument xmlDocument = new XmlDocument();
            xmlDocument.Schemas.Add(schemaSet);
            xmlDocument.LoadXml("<root><element1>value1</element1><element2>value2</element2></root>");

            // Valida o documento XML
            xmlDocument.Validate(null);

            // Salva o arquivo XML válido
            xmlDocument.Save("C:\\Users\\Tecsoluti\\Desktop\\Esocial Oficial\\BibliotecaEsocial\\BibliotecaEsocial\\XML\\evtAdmissao.xml");
            
            //Geração do XML para salvar como String 
            // --> xmlDocument.InnerXml;

            Console.WriteLine(xmlDocument.InnerXml);


            // Lendo e validando XML contra XSD

            LeituraXSD(schemaSet);

            return "";
        }

        public void LeituraXSD(XmlSchemaSet schemaSet )
        {

            // Carrega o arquivo XML a ser validado
            XmlReader reader = XmlReader.Create("C:\\Users\\Tecsoluti\\Desktop\\Esocial Oficial\\BibliotecaEsocial\\BibliotecaEsocial\\XML\\evtAdmissao.xml");
            // Carrega o arquivo de esquema XSD

            // Define as configurações de validação
            XmlReaderSettings settings = new XmlReaderSettings();
            settings.ValidationType = ValidationType.Schema;
            settings.Schemas.Add(schemaSet);

            // Valida o arquivo XML
            settings.ValidationEventHandler += ValidationEventHandler;
            using (XmlReader validatingReader = XmlReader.Create(reader, settings))
            {
                while (validatingReader.Read())
                {
                    Console.WriteLine(validatingReader.Name);
                }
            }

        }

        public void ValidationEventHandler(object sender, ValidationEventArgs e)
        {
            if (e.Severity == XmlSeverityType.Error)
            {
                Console.WriteLine("Erro de validação: " + e.Message);
            }
            else
            {
                Console.WriteLine("Aviso de validação: " + e.Message);
            }
        }


        
        public void RegrasGerais()
        {

        }

        public void S_1000()
        {
        }

        public void s_1005()
        {
        }

    }
}




