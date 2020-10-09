using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CAI_EXPENDEDORA.Entidades;

namespace CAI_EXPENDEDORA
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Selecciones una de las opciones:" + Environment.NewLine +
            "1. Encender" + Environment.NewLine +
            "2. Lista Lata" + Environment.NewLine +
            "3. Insertar Lata" + Environment.NewLine +
            "4. Extraer Lata" + Environment.NewLine +
            "5. Obtener Balacance" + Environment.NewLine +
            "6. Mostrar Stock" + Environment.NewLine +
            "7. Salir" + Environment.NewLine);

            Expendedora Exp = new Expendedora();
            string Eleccion = "";
            string Mensaje = "";
            bool Incorrecto = false;

            do
            {
                Incorrecto = false;
                if (Eleccion == "1")
                {
                    Mensaje = "Usted eligio: Encender";
                    Exp.EncenderMaquina();
                }
                else if (Eleccion == "2")
                {
                    Mensaje = "Usted eligio: Lista Lata";
                    Exp.AgregarLata();
                }
                else if (Eleccion == "3")
                {
                    Mensaje = "Usted eligio: Insertar Lata";
                    IngresarLata(Exp);

                }
                else if (Eleccion == "4")
                {
                    Mensaje = "Usted eligio: Extraer Lata";
                    ExtraerLata(Exp);

                }
                else if (Eleccion == "5")
                {
                    Mensaje = "Usted eligio: Obterner Balance";
                    ObtenerBalance(Exp);
                }
                else if (Eleccion == "6")
                {
                    Mensaje = "Usted eligio: Mostrar Stock";
                    MostarStock(Exp);

                }
                else if (Eleccion == "7")
                {
                    Mensaje = "Usted eligio: Salir";
                }
                else
                {
                    Mensaje = "Usted ingreso un dato erroneo" + Environment.NewLine +
                        "Ingrese otra opcion";
                    Incorrecto = true;
                }
                Console.WriteLine(Mensaje);
            }
            while (Incorrecto == true);



            static void IngresarLata(Expendedora expendedora)
            {
                Lata NuevaLata = new Lata();
                Console.WriteLine(expendedora.ListaLata());
                try
                {
                    Console.WriteLine("Ingrese el codigo de la lata");
                    string Codigo = "";
                    do
                    {
                        Codigo = Console.ReadLine();
                        if (VALIDACION.ValidarCodigo(Codigo))
                        {
                            Console.WriteLine("No ingreso el codigo de la lata");
                        }
                    } while (Codigo == "");

                }
                catch (CodigoValidoExcepcion CVE)
                {
                    Console.WriteLine(CVE.Message);
                }
            }
        }

            }
            static void ExtraerLata(Expendedora expendedora)
            {

            }
            static void ObtenerBalance(Expendedora expendedora)
            {

            }
            static void MostrarStock(Expendedora expendedora)
            {
            }
        }

    }
}

