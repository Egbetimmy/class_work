using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wema.BIT.IRepository
{
    public abstract class Animal
    {
        public abstract void animalSound();
        public void sleep() 
        {
            Console.WriteLine("Zzz"); 
        }
    }

    public class ImplementAnimal : Animal 
    {
        public override void animalSound()
        {
            Console.WriteLine("This Animal sleeps way up");
        }
    }

     class animalService 
    {
        ImplementAnimal animal = new ImplementAnimal();
        public void sleep() 
        {
            animal.sleep();
        }

        public void AnimalSound()
        {
            animal.animalSound();
        }
    }
}
