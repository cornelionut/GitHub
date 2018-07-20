//using GestiuneStocuri;
//using System;
//using System.Collections;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace Gestiune_stocuri
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            MateriiPrime mp1 = new MateriiPrime();
//            MateriiPrime mp2 = new MateriiPrime("Bucse", 50, 10);
//            MateriiPrime mp3 = mp2.Clone();

//            ArrayList listaMateriiPrime = new ArrayList();
//            listaMateriiPrime.Add(mp1);
//            listaMateriiPrime.Add(mp2);
//            listaMateriiPrime.Add(mp3);

//            foreach (MateriiPrime mp in listaMateriiPrime)
//            {
//                Console.WriteLine(mp.ToString());
//            }

//            //CLASA ABSTRACTA
//            Console.WriteLine();
//            MateriiPrime mp4 = new MateriiPrime("Pivoti", 10f, 20);
//            Console.WriteLine("Valoarea pivotilor = {0}", mp4.valoareProduse());

//            Depozit depozit = new Depozit();
//            depozit.ListaAnimale.Add(mp1);
//            depozit.ListaAnimale.Add(mp2);
//            depozit.ListaAnimale.Add(mp3);
//            depozit.ListaAnimale.Add(mp4);
//            Console.WriteLine();

//            for (int i = 0; i < depozit.ListaAnimale.Count; i++)
//            {
//                Console.WriteLine("Valoare produsului[" + i + "]=" + depozit.ListaAnimale[i].valoareProduse());
//            }


//            // OPERATOR INDEX
//            Console.WriteLine(); Console.WriteLine("VALOARE PRODUSE:");
//            for (int i = 0; i < depozit.ListaAnimale.Count; i++)
//            {
//                Console.WriteLine(depozit[i].valoareProduse());
//            }
        

//            //INTERFATA
//            IValoare obj = new MateriiPrime();
//            obj.valoareProduse();

//            Console.ReadKey();
//        }
//    }
//}
