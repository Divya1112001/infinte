using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practice_19_10
{
    public class wildAnimalFactory : AnimalFactory
    {
        public override IAnimal GetAnimal(string Animaltype)
        {
            if (Animaltype.Equals("Tiger"))
            {
                return new Dog();
            }
            else if (Animaltype.Equals("Wolf"))
            {
                return new Cat();
            }
            
            else
                return null;
        }
    }
}
