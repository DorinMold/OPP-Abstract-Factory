using System;
using System.Text;
using AbstractFactoryLib;

namespace OPP_Abstract_Factory
{
    class Program
    {
        static int Var1 = 3;
        static int Var2 = 0;
        static int Var3 =  5;
        static int Rezultat;
        

        static void Main(string[] args)
        {
            ApplicationLog logger = new ApplicationLog();

           // Cazul primei erori de impartire la zero
            try
            {
                Rezultat = Var1 / Var2;
            } catch(Exception e)
            {
                Console.WriteLine($"---------Eroare Impartire {Var1} la {Var2}--------------------");
                logger.ErConsola().Afisare(NivelEroare.Avertizare, e.Message);
                logger.ErDebug().Afisare(NivelEroare.Avertizare, e.Message);
            }

            //cazul altei erori de impartire la zero
            try
            {
                Rezultat = Var3 / Var2;
            }
            catch (Exception e)
            {
                Console.WriteLine($"---------Eroare Impartire {Var3} la {Var2}--------------------");
                logger.ErConsola().Afisare(NivelEroare.Sever, e.Message);
                logger.ErDebug().Afisare(NivelEroare.Sever, e.Message);
            }

            //cazul ultimei erori de impartire la zero
            try
            {
                Rezultat = int.Parse("eroare");
            }
            catch (Exception e)
            {
                Console.WriteLine($"---------Eroare Impartire {Var3} la {Var2}--------------------");
                logger.ErConsola().Afisare(NivelEroare.Critic, e.Message);
                logger.ErDebug().Afisare(NivelEroare.Critic, e.Message);
            }
        }
    }
}
