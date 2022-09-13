using System;
using System.Collections.Generic;
using System.Text;

namespace exchien
{
    class Chien
    {
        private string _nom;
        private string _race;
        private uint _age;

        public Chien(string nom,string race,uint age)
        {
            this._nom = nom;
            this._race = race;
            this._age = age;
        }

        public string AfficheCaracteristique()
        {
            return "Nom : " + this._nom + " - Age : " + this._age + " - Race " + this._race;
        }
    }


}
