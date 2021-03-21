using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms; //Needed for message box

namespace Polymorphism
{
    class Animal
    {
        //field
        private string _species;

        //constructor
        public Animal(string species)
        {
            _species = species;
        }

        //species property
        public string Species
        {
            get { return _species; }
            set { _species = value; }
        }

        //makesound method
        public virtual void MakeSound()
        {
            MessageBox.Show("Grrrrrrr");
        }
    }
}
