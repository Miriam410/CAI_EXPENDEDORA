using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAI_EXPENDEDORA.Entidades
{
    public class Expendedora
    {
        private List<Lata> _lata;
        private List<Lata> _lataLista;
        private string _proveedor;
        private int _capacidad;
        private double _dinero;
        private bool _encendido;

        public bool Encender()
        {
            this._encendido = true;
            return this._encendido;
        }

        public void EncenderMaquina()
        {
            string Mensaje = "";
            if (Encender())
            {
                Mensaje = "La maquina esta encendida";
            }
            Console.WriteLine(Mensaje);
        }
        public void AgregarLata()
        {
            _lataLista = new List<Lata>();
            _lataLista.Add(new Lata("CO1","Coca Cola","Regular"));
            _lataLista.Add (new Lata("CO2", "Coca Cola", " Zero"));
            _lataLista.Add (new Lata("SP1", "Sprite", " Regular"));
            _lataLista.Add(new Lata("SP2", "Sprite", " Zero"));
            _lataLista.Add (new Lata("FA1", "Fanta", " Regular"));
            _lataLista.Add (new Lata("FA3","Fanta","Zero"));

        }

   
        public string ListaLata()
        {
            string LataAcumulado = "";
            foreach (Lata L in _lataLista)
            {
                LataAcumulado += L.ToString();
            }
            return LataAcumulado;
        }

        public Lata ValidarCodigo(string Codigo)
        {
            bool Encontrado = false;
            
            foreach (Lata  BuscarLata in _lataLista)
            {
                if (BuscarLata.Codigo == Codigo)
                {
                    Encontrado = true;
                }
            }
            if (Encontrado)
            {
                   throw new CodigoValidoExcepcion();
               
            }

        }   

        public Lata ExtraerLata(string Codigo, double Plata)
        { 
           

        }

        public string GetBalance()
        { 
            
        }

        public int GetCapacidadRestante()
        { 
            return this._capacidad - _lata.Count();
        }

       

        public bool EstaVacio()
        { 
            if(_lata.Count==0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
