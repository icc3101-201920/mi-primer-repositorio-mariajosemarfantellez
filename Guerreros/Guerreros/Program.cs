using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Guerreros
{
    class Program
    {
        static void Main(string[] args)
        {
            Combatientes Mage = new Combatientes();
            Mage.Atacar = "Atacar";
            Mage.AtaqueEspecial = "Mage Attack";
            Mage.Defender = "Defender";

            Combatientes Warrior = new Combatientes();
            Warrior.Atacar = "Atacar";
            Warrior.AtaqueEspecial = "Warrior Attack";
            Warrior.Defender = "Defender";
        }
    }
}
