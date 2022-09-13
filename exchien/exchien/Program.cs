using System;

namespace exchien
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bienvenue dans notre chenil");
            Chien medor = new Chien("Médor", "Caniche", 13);
            Chien[] mesChiens = new Chien[3];
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("quel est le nom du chien?");
                string nomChien = Console.ReadLine();
                Console.WriteLine("quel est la race du chien?");
                string raceChien = Console.ReadLine();
                Console.WriteLine("quel est l'age du chien?");
                uint ageChien = uint.Parse(Console.ReadLine());

                mesChiens[i] = new Chien(nomChien, raceChien, ageChien);
                Console.WriteLine(mesChiens[i].AfficheCaracteristique());
            }
        }
    }
}
