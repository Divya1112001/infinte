using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practice_19_10
{

    public class SeaAnimalFactory : AnimalFactory
    {
        public override IAnimal GetAnimal(string Animaltype)
        {
            if (Animaltype.Equals("Shark"))
            {
                return new Shark();
            }
            else if (Animaltype.Equals("Octopus"))
            {
                return new Octopus();
            }
            else
                return null;
        }
    }
        }
