using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAI_EXPENDEDORA.Entidades
{
    public class VALIDACION
    {
        public static bool ValidarCodigo(string ValidarCod)
        {
            bool Valido = false;
            if (ValidarCod == "")
            {
                Valido = false;
            }
            else
            {
                Valido = true;
            }
            return(Valido);
        }
    }
}
