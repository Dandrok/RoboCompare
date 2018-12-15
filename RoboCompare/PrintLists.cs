using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoboCompare
{
    class PrintLists
    {
        ListaOps listaOps = new ListaOps();
        ListaOps2 listaOps2 = new ListaOps2();


        public void PrintsList()
        {
            var listaTest1 = listaOps.Compare();
            var listaTest2 = listaOps2.Compare();
            foreach (var obj in listaTest1)
            {
                Console.WriteLine(obj.Random1);
                Console.WriteLine(obj.Random2);
                Console.WriteLine(obj.Random3);
                Console.WriteLine(obj.Random4);
                Console.WriteLine(obj.Random5);
                Console.WriteLine(obj.Random6);
                Console.WriteLine(obj.Random7);
                Console.WriteLine(obj.Random8);
                Console.WriteLine(obj.Random9);
                Console.WriteLine(obj.Random10);
            }

            foreach (var obj in listaTest2)
            {
                Console.WriteLine(obj.Random1);
                Console.WriteLine(obj.Random2);
                Console.WriteLine(obj.Random3);
                Console.WriteLine(obj.Random4);
                Console.WriteLine(obj.Random5);
                Console.WriteLine(obj.Random6);
                Console.WriteLine(obj.Random7);
                Console.WriteLine(obj.Random8);
                Console.WriteLine(obj.Random9);
                Console.WriteLine(obj.Random10);
            }



            Console.ReadKey();
        }

        public List<string> Twin()
        {
            List<string> list1 = new List<string>();
            List<string> list2 = new List<string>();
            List<string> listResult = new List<string>();


            foreach (var obj in listaOps.Compare())
            {
                list1.Add(obj.Random1);
                list1.Add(obj.Random2);
                list1.Add(obj.Random3);
                list1.Add(obj.Random4);
                list1.Add(obj.Random5);
                list1.Add(obj.Random6);
                list1.Add(obj.Random7);
                list1.Add(obj.Random8);
                list1.Add(obj.Random9);
                list1.Add(obj.Random10);

            }

            foreach (var obj in listaOps2.Compare())
            {
                list2.Add(obj.Random1);
                list2.Add(obj.Random2);
                list2.Add(obj.Random3);
                list2.Add(obj.Random4);
                list2.Add(obj.Random5);
                list2.Add(obj.Random6);
                list2.Add(obj.Random7);
                list2.Add(obj.Random8);
                list2.Add(obj.Random9);
                list2.Add(obj.Random10);
            }


            foreach (var obj in list1)
            {
                if (list2.Any(obj2 => obj.Equals(obj2)))
                {
                    listResult.Add(obj);
                }
            }

            return listResult;


        }
    }
}
