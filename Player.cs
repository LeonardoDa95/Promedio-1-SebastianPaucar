using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Lifetime;
using System.Text;
using System.Threading.Tasks;

namespace Promedio1_SP
{
    internal class Player
    {
        public int ahp = 5;
        public int round = 1;
        public int resources = 100;
        public int resourcesLV = 1;

        public void ResourcesUpgradeeeeee()
        {
            resourcesLV++;
        }
        public void PassRounddddddd()
        {
            resources *= resourcesLV;
            round++;
        }



    }
}
