using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactoryLib
{
    public enum NivelEroare
    {
        Avertizare = 0,
        Sever = 1,
        Critic = 2
    }
    public class EroareContext
    {
        public static string MesajAvertizare = "Acesta este un mesaj de avertizare moderata";
        public static string MesajSever = "Acesta este un mesaj de avertizare ridicata";
        public static string MesajCritic = "Acesta este un mesaj de avertizare critica";
    }
}
