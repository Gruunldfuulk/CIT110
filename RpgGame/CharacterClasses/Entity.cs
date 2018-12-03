using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RpgGame.CharacterClasses
{
    public enum EntityGender { Male, Female, Unknown }

    public abstract class Entity
    {
        #region FIELDS
        protected string _name;
        protected EntityGender _gender;
        protected int _physique, _cunning, _spirit, _health, _energy;
        protected int _physiqueModifier, _cunningModifier, _spiritModifier, _healthModifier, _energyModifier;

        #endregion

        #region PROPERTIES
        public string Name
        {
            get { return _name; }
            protected set { _name = value; }
        }
        public EntityGender Gender
        {
            get { return _gender; }
        }
        public int Physique
        {
            get { return _physique + _physiqueModifier; }
            protected set { _physique = value; }
        }
        public int Cunning
        {
            get { return _cunning + _cunningModifier; }
            protected set { _cunning = value; }
        }
        public int Spirit
        {
            get { return _spirit + _spiritModifier; }
            protected set { _spirit = value; }
        }
        public int Health
        {
            get { return _health + _healthModifier; }
            protected set { _health = value; }
        }
        public int Energy
        {
            get { return _energy + _energyModifier; }
            protected set { _energy = value; }
        }


        #endregion

        #region CONSTRUCTOR
        public Entity()
        {
            //Starting Character Values
            Name = "";
            Physique = 0;
            Cunning = 0;
            Spirit = 0;
            Health = 0;
            Energy = 0;
            
        }


        #endregion

        #region METHODS

        #endregion
    }
}
