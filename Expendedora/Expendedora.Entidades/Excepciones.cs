using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CAI_EXPENDEDORA.Entidades
{
    class CodigoValidoExcepcion : Exception
    {
        public CodigoValidoExcepcion() : base("No se encontro el codigo");
        
           
    }
}
