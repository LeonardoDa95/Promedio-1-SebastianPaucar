using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Promedio1_SP
{
    internal class Menu
    {
        private List<Units> allieunits;
        private List<Units> enemyunits;
        private Player player = new Player();
        private Enemy enemy = new Enemy();
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
                        if (player.resources >= 10)
                        {
                            CreateUnit();
                        }
                            break;
                    case "2":
                        if (player.resources >= 20)
                        {
                            UpgradeResources();
                        }
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
            allieunits.Add(new Units());
        }
        private void UpgradeResources()
        {
            player.ResourcesUpgradeeeeee();
        }
        private void PassRound()
        {
            if (allieunits.Count > enemyunits.Count)
            {
                Console.WriteLine("Ganaste esta ronda y atacaste el campamento rival");
                enemy.ehp--;
            }
            else if (allieunits.Count < enemyunits.Count)
            {
                Console.WriteLine("Perdiste esta ronda y atacaron tu campamento");
                player.ahp--;
            }
            else if (allieunits.Count == enemyunits.Count)
            {
                Console.WriteLine("Empate ambos tienen las mismas fuerzas");
            }
                player.PassRounddddddd();
            if (player.ahp <= 0)
            {
                Console.WriteLine("Te has quedado sin vidas...PERDISTE");
            }
            if (enemy.ehp <= 0)
            {
                Console.WriteLine("El enemigo se quedo sin vidas...¡GANASTE!");
            }
        }
        private void EnemySpawn()
        {
            enemy.EnemySpawnnnnnnn();
        }

    }

}