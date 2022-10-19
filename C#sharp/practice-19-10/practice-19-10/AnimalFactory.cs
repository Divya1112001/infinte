using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practice_19_10
{
    public abstract class AnimalFactory
    {
        public abstract IAnimal GetAnimal(string Animaltype);

        public static AnimalFactory CreateAnimalFactory(string Factorytype)
        {
            if (Factorytype.Equals("Sea"))
            {
                return new SeaAnimalFactory();
            }
            else if (Factorytype.Equals("Land"))
            {
                return new LandAnimalFactory();
            }
            else
                return null;
        }
    }
}
