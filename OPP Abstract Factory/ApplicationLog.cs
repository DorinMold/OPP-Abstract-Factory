using System;
using System.Collections.Generic;
using System.Text;
using AbstractFactoryLib;

namespace OPP_Abstract_Factory
{
    class ApplicationLog : AbstractFactory
    {
        public override EroareConsola ErConsola()
        {
            return new EroareConsola();
        }

        public override EroareDebug ErDebug()
        {
            return new EroareDebug();
        }
    }
}
