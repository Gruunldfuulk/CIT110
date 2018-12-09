using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RpgGame.CharacterClasses
{
    class Fighter : Player
    {
        Random rand = new Random();

        public Fighter() :
            base()
        {

        }
        public Fighter(string name, EntityGender gender, EntityClass eClass) : 
            base()
        {
            Name = name;
            Gender = gender;
            _physique = rand.Next(5, 10);
            _spirit = rand.Next(1, 5);
            _cunning = rand.Next(3, 7);
            _health = rand.Next(10, 14);
            _energy = rand.Next(4, 8);
        }
    }
}
