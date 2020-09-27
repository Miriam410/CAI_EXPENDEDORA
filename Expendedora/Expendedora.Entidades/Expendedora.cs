using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Expendedora.Entidades
{
    public class Expendedora
    {
        private List<Lata> _lata;
        private string _proveedor;
        private int _capacidad;
        private double _dinero;
        private bool _encendido;

        public void AgregarLata()
        {
            this._lata = new List<Lata>();
            _lata.Add(Lata);

        }

        public Lata ExtraerLata(string, double)
        { 
        }

        public string GetBalance()
        { 
        }

        public int GetCapacidadRestante()
        { 
        }

        public void EncenderMaquina()
        { 
        
        }

        public bool EstaVacio()
        { 
        }
    }
}
