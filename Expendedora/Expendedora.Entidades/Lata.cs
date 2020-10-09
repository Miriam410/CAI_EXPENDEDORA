using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAI_EXPENDEDORA.Entidades
{
    public class Lata 
    {
        private string _codigo;
        private string _nombre;
        private string _sabor;
        private double _precio;
        private double _volumen;

        public string Codigo
        {
            get 
            {
                return _codigo;
            }
            set
            {
                _codigo = value;
            }
        }
        
        public string Nombre
        {
            get
            {
                return _nombre;
            }
            set
            {
                _nombre= value;
            }
        }

        public string Sabor
        {
            get
            {
                return _sabor;
            }
            set 
            {
                _sabor = value;
            }
        }

        public double Precio
        {
            get
            {
                return _precio;
            }
            set
            {
                if(value>0)
                {
                    _precio = value;
                }
                else
                {
                    throw new Exception("El precio debe ser mayor a 0");
                }
                
            }
        }

        public double Volumen
        {
            get
            {
                return _volumen;            
            }
            set
            {
                if(value>0)
                {
                    _volumen=value;
                }
                else
                {
                    throw new Exception("Ingrese un volumen mayor a 0")
                }
            }
        }

        public double GetPrecioPorLitro()
        {
            return _precio * _volumen;
        }

        public Lata(string Codigo,string Nombre, string Sabor)
        {
            this._codigo = Codigo;
            this._nombre = Nombre;
            this._sabor = Sabor;  
        }

        public Lata(string Codigo, string Nombre, string Sabor, double Precio, double Volumen)
        {
            this._codigo = Codigo;
            this._nombre = Nombre;
            this._sabor = Sabor;
            this._precio = Precio;
            this._volumen = Volumen;
        }
        public override string ToString()
        {
            return string.Format( this._nombre + "-" +  this._sabor + "-" + "$"+this._precio + "$/L" + GetPrecioPorLitro());
            
        }
       
    }
}
