using System;
using static Warrior.Class1;

namespace Warrior
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

            Combatientes Knight = new Combatientes();
            Knight.Atacar = "Atacar";
            Knight.AtaqueEspecial = "Knight Attack";
            Knight.Defender = "Defender";

            Armaduras armadura1 = new Armaduras();
            armadura1.armorPoints = 3;
            Armaduras armadura2 = new Armaduras();
            armadura2.armorPoints = 5;
            Armaduras armadura3 = new Armaduras();
            armadura3.armorPoints = 7;

            Armas cuchillo = new Armas();
            cuchillo.Damage = 6;
            cuchillo.Habilidad = "Corto Alcance";
            Armas pistola = new Armas();
            pistola.Damage = 9;
            pistola.Habilidad = "Largo Alcance";
            Armas cuerda = new Armas();
            cuerda.Damage = 2;
            cuerda.Habilidad = "Ahogar";

        }
    }
}
