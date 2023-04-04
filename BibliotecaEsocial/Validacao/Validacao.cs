using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Schema;
using System.Xml.Serialization;
using BibliotecaEsocial.ClassesEsquemas;

namespace BibliotecaEsocial.Validacao
{
public class Validacao
{
    private string URI = "" ;
    
    public  string Validate(string nomeXml , string uriXml, string caminhoEsquema)
        {

            // Carrega o arquivo de esquema XSD
            XmlSchemaSet schemaSet = new XmlSchemaSet();
            schemaSet.Add(null, caminhoEsquema + "PacoteXSD\\evtAdmissao.xsd");
            schemaSet.Compile();

            // Cria o documento XML a partir do esquema
            XmlDocument xmlDocument = new XmlDocument();
            xmlDocument.Schemas.Add(schemaSet);
            xmlDocument.LoadXml("<root><element1>value1</element1><element2>value2</element2></root>");

            // Valida o documento XML
            xmlDocument.Validate(null);

            // Salva o arquivo XML válido
            xmlDocument.Save(caminhoEsquema+"XML\\evtAdmissao.xml");
            
            //Geração do XML para salvar como String 
            // --> xmlDocument.InnerXml;

            Console.WriteLine(xmlDocument.InnerXml);

            // Lendo e validando XML contra XSD

            LeituraXSD(schemaSet,caminhoEsquema);

            // 200 - 160 - 300 - 300 =  860 - 2000 = 1.140 =
            
            return "";
            }

        public void LeituraXSD(XmlSchemaSet schemaSet, string esquemaURI )
        {
            // Carrega o arquivo XML a ser validado
                XmlReader reader = XmlReader.Create(esquemaURI+"XML\\evtAdmissao.xml");
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

        public void EvtAdmissao()
        {

        }
    }
}




