using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RpgGame.CharacterClasses
{
    public class Player : Entity
    {
        Random rand = new Random();
        public Player() : base()
        {
        }

        public Player(string name, EntityGender eGender, EntityClass eClass) :
            base()
        {
            Name = name;
            Gender = eGender;
            CharacterClass = eClass;
            _physique = rand.Next(5, 10);
            _spirit = rand.Next(1, 5);
            _cunning = rand.Next(3, 7);
            _health = rand.Next(10, 14);
            _energy = rand.Next(4, 8);

        }

        // If the user wants to input the stats
        public Player(string name, EntityGender eGender, EntityClass eClass, int physique,
        int cunning, int spirit, int health, int energy)
        {
            Name = name;
            Gender = eGender;
            CharacterClass = eClass;
            Physique = _physique;
            Cunning = _cunning;
            Spirit = _spirit;
            Health = _health;
            Energy = _energy;
        }
        
           

}
}
