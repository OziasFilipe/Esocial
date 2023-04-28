using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;
using BibliotecaEsocial.ClassesEsquemas;
using BibliotecaEsocial.Eventos.S1005;
using BibliotecaEsocial.Eventos.S1010;
using BibliotecaEsocial.Eventos.S1020;
using BibliotecaEsocial.Eventos.S1070;
using BibliotecaEsocial.Eventos.S2190;
using BibliotecaEsocial.Eventos.S2200;
using BibliotecaEsocial.Eventos.S2206;
using BibliotecaEsocial.Eventos.S2210;
using BibliotecaEsocial.Eventos.S2220;
using BibliotecaEsocial.Eventos.S2230;
using BibliotecaEsocial.Eventos.S2231;
using BibliotecaEsocial.Eventos.S2240;
using BibliotecaEsocial.Eventos.S2298;
using BibliotecaEsocial.Eventos.S2300;
using BibliotecaEsocial.Eventos.S2306;
using BibliotecaEsocial.Eventos.S2400;
using BibliotecaEsocial.Eventos.S2405;
using BibliotecaEsocial.Eventos.S2410;
using BibliotecaEsocial.Eventos.S2416;
using BibliotecaEsocial.Eventos.S2418;
using BibliotecaEsocial.Eventos.S2420;
using BibliotecaEsocial.Eventos.S5001;
using BibliotecaEsocial.Eventos.S5002;
using BibliotecaEsocial.Eventos.S5003;
using BibliotecaEsocial.Eventos.S5011;
using BibliotecaEsocial.Eventos.S5013;
using BibliotecaEsocial.Validacao;


namespace BibliotecaEsocial
{
    class Program
    {
        static void Main(string[] args)
        {

            S5013 teste = new S5013();
            teste.s5013();

        }
    }
}
