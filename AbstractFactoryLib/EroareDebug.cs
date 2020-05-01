using System;
using System.Collections.Generic;
using System.Text;
using System.Diagnostics;

namespace AbstractFactoryLib
{
    public class EroareDebug
    {
        public void Afisare( NivelEroare NivEr)
        {
            int i = (int)NivEr;
            switch (i)
            {
                case 0:
                    Debug.WriteLine(EroareContext.MesajAvertizare);
                    break;
                case 1:
                    Debug.WriteLine(EroareContext.MesajSever);
                    break;
                case 2:
                    Debug.WriteLine(EroareContext.MesajCritic);
                    break;
            }
        }
    }
}
