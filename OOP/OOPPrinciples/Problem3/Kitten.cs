using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem3
{
    class Kitten : Animals : ISound
    {
        private const string  sex = "Female";

        public Kitten(int age, string name, string sex) : base (age, name, sex)
        {

        }
        public string Sound(string sound)
        {
            string kittenSound = sound;
            return kittenSound;
        }
        
    }
}
