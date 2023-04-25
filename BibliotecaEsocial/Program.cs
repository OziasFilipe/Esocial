using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;
using BibliotecaEsocial.ClassesEsquemas;
using BibliotecaEsocial.Eventos.S1010;
using BibliotecaEsocial.Eventos.S2190;
using BibliotecaEsocial.Eventos.S2206;
using BibliotecaEsocial.Eventos.S2210;
using BibliotecaEsocial.Eventos.S2220;
using BibliotecaEsocial.Eventos.S2230;
using BibliotecaEsocial.Eventos.S2231;
using BibliotecaEsocial.Eventos.S2240;
using BibliotecaEsocial.Eventos.S2298;
using BibliotecaEsocial.Eventos.S2300;
using BibliotecaEsocial.Eventos.S2306;
using BibliotecaEsocial.Validacao;


namespace BibliotecaEsocial
{
    class Program
    {
        static void Main(string[] args)
        {

            S2306 teste = new S2306();
            teste.s2306();

        }
    }
}
