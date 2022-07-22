using Semana_4_Oliver_1100292.dsPeruTableAdapters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Semana_4_Oliver_1100292
{
    internal class Program
    {
        static void Main(string[] args)
        {
            AfectadosTableAdapter adapter = new AfectadosTableAdapter();
            EventoTableAdapter adapter1 = new EventoTableAdapter();


            adapter1.ppInsertEvento("Terremoto 7.0", "Terremoto", DateTime.Parse("05/06/2022"), "Peru", "Gran terremoto en peru que dejo muchos heridos");
            adapter.ppInsertAfectados("Cedula","Alicia","Morel",DateTime.Parse("23/02/2002"),"Mujer",DateTime.Now,"Cabeza",1);
            Console.WriteLine("listo");
        }
    }
}
