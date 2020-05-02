using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactoryLib
{
    public class EroareConsola
    {
        public void Afisare(NivelEroare NivEr, String Mesaj) {
            int i = (int)NivEr ;
            switch ( i )
            {
                case 0:
                    Console.WriteLine(String.Concat(EroareContext.MesajAvertizare, ": ", Mesaj));
                    break;
                case 1:
                    Console.WriteLine(String.Concat(EroareContext.MesajSever, ": ", Mesaj));
                    break;
                case 2:
                    Console.WriteLine(String.Concat(EroareContext.MesajCritic, ": ", Mesaj));
                    break;
            }
        }
    }
}
