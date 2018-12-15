using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.SqlClient;

namespace RoboCompare
{
    class Program
    {
        static void Main(string[] args)
        {
            //ListaOps listaOps = new ListaOps();
            //ListaOps2 listaOps2 = new ListaOps2();
            PrintLists printLists = new PrintLists();
            //PrintLists pL = new PrintLists();

            //listaOps.Populate();
            //listaOps2.Populate();
            //new PrintLists().PrintsList();
            //new PrintLists().Twin();

            foreach (var obj in printLists.Twin())
            {
                Console.Write(obj);
            }
            Console.ReadKey();
        }

    }
}

