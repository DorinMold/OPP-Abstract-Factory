using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactoryLib
{
    public class EroareConsola
    {
        public void Afisare(NivelEroare NivEr) {
            int i = (int)NivEr ;
            switch ( i )
            {
                case 0:
                    Console.WriteLine(EroareContext.MesajAvertizare);
                    break;
                case 1:
                    Console.WriteLine(EroareContext.MesajSever);
                    break;
                case 2:
                    Console.WriteLine(EroareContext.MesajCritic);
                    break;
            }
        }
    }
}
