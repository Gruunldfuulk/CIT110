using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RpgGame.CharacterClasses
{
    class Wizard : Entity
    {
        Random rand = new Random();

        public Wizard() :
            base()
        {

        }
        public Wizard(string name, EntityGender gender, EntityClass eClass) :
            base()
        {
            Name = name;
            Gender = gender;
            _physique = rand.Next(1, 5);
            _spirit = rand.Next(5, 10);
            _cunning = rand.Next(3, 7);
            _health = rand.Next(5, 8);
            _energy = rand.Next(10, 14);
        }

    }
}
