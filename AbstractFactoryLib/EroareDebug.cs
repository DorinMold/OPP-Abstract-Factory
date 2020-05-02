using System;
using System.Collections.Generic;
using System.Text;
using System.Diagnostics;

namespace AbstractFactoryLib
{
    public class EroareDebug
    {
        public void Afisare( NivelEroare NivEr, string Mesaj )
        {
            int i = (int)NivEr;
            switch (i)
            {
                case 0:
                    Debug.WriteLine( String.Concat(EroareContext.MesajAvertizare, ": ", Mesaj) );
                    break;
                case 1:
                    Debug.WriteLine( String.Concat(EroareContext.MesajSever, ": ", Mesaj) );
                    break;
                case 2:
                    Debug.WriteLine( String.Concat(EroareContext.MesajCritic, ": ", Mesaj) );
                    break;
            }
        }
    }
}
