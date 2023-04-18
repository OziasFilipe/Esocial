using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;
using BibliotecaEsocial.ClassesEsquemas;
using BibliotecaEsocial.Eventos.S2190;
using BibliotecaEsocial.Validacao;


namespace BibliotecaEsocial
{
    class Program
    {
        static void Main(string[] args)
        {
            // S2200 s2200 = new S2200();
            // s2200.tContato.emailPrinc = "ozias.pecanhaa@gmail.com";
            // s2200.tContato.fonePrinc = "";
            // s2200.S_2200();

            S2190 s2190 = new S2190();
            s2190.matricula = "Matricula";
            s2190.S_2190();
            // s2200.admissaoVinculoMudancaCpf = 




        }
    }
}
