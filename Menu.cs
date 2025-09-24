using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Promedio1_SP
{
    internal class Menu
    {
        private List<Units> units;
        private void ShowGameMenu()
        {
            bool continueFlag = true;
            while (continueFlag)
            {
                Console.WriteLine("Es tu turno elige tu accion");
                Console.WriteLine("1. Crear una unidad");
                Console.WriteLine("2. Mejorar la recoleccion de recursos");
                Console.WriteLine("0. Salir");

                string option = Console.ReadLine();
                switch (option)
                {
                    case "1":
                        CreateUnit();
                        break;
                    case "2":
                        UpgradeResources();
                        break;
                    case "0":
                        continueFlag = false;
                        break;
                    default:
                        Console.WriteLine("Opcion no valida");
                        break;
                }
            }
        }
        private void CreateUnit()
        {

        }
        private void UpgradeResources()
        {

        }
    }

}