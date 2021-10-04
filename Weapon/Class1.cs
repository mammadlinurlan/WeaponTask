using System;

namespace Weapon
{
    public class Weapon
    {
        private int _ammo;

        public Weapon(int ammo)
        {
            this._ammo = ammo;
        }

        public void Shoot(string shootingMode)
        {
            if (_ammo >= 0 && _ammo <= 30)
            {
                if (shootingMode == "auto" || shootingMode == "single")
                {
                    if (shootingMode == "auto")
                    {
                        while (_ammo > 0)
                        {
                            _ammo--;
                            Console.WriteLine($"Shooted : Now your ammo = {_ammo}");
                        }
                        {
                            Console.WriteLine($"You have shooted all of your ammo. Your ammo = {_ammo} Reload please");
                            Console.WriteLine("insert ammo count for reload");
                            int reloadammo = Int32.Parse(Console.ReadLine());
                            if (_ammo + reloadammo <= 30)
                            {
                                _ammo += reloadammo;
                                Console.WriteLine($"you have reloaded. Now your ammo = {_ammo}");
                                Shoot(shootingMode);
                                return;
                            }
                            Console.WriteLine("not enough space for that reloud ammo count");
                            return;
                        }
                    }
                    else
                    {
                        if (_ammo > 0)
                        {
                            _ammo--;
                            Console.WriteLine($"You had a single shot , now your ammo = {_ammo}");
                            Console.WriteLine("do you want to shoot again?  : yes || no");
                            string answer = Console.ReadLine();
                            if (answer == "yes" || answer == "no")
                            {
                                if (answer == "yes")
                                {
                                    Shoot(shootingMode);
                                }
                                else
                                {
                                    Console.WriteLine("----------------END-----------------");
                                }
                                return;
                            }
                        }
                        else
                        {
                            Console.WriteLine("Not ammo , please reload. Insert reload count");
                            int reloadammo = Int32.Parse(Console.ReadLine());
                            if (_ammo + reloadammo <= 30)
                            {
                                _ammo += reloadammo;
                                Console.WriteLine($"you have reloaded. Now your ammo = {_ammo}");

                                Shoot(shootingMode);
                            }
                            else
                            {
                                Console.WriteLine("not enough space for that reloud ammo count");
                            }
                            return;
                        }
                    }
                }
                else
                {
                    Console.WriteLine("ShootingMode must be auto or single");
                    return;
                }
            }
            Console.WriteLine("ammo must be between 0 and 30");
        }
    }
}


