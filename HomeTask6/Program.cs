using System;
using Weapon;

namespace HomeTask6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Insert ammo");
            int ammo = Int32.Parse(Console.ReadLine());

            Weapon.Weapon weapon1 = new Weapon.Weapon(ammo);

            Console.WriteLine("Shooting mode : auto|single");
            string shootingMode = Console.ReadLine();

            weapon1.Shoot(shootingMode);

        }
    }
}
