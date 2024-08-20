using Practice5.Task3.Model;
using System;
using System.Collections.Generic;

namespace Practice5.Task3
{
  internal class Program
  {
    static void Main(string[] args)
    {
      var dog = new Dog("Тоби", 3);
      dog.Sleep();
      dog.Eat();
      dog.MakeSound();

      var cat = new Cat("Арбузик", 4);
      cat.Sleep();
      cat.Eat();
      cat.MakeSound();

      var animal = new Animal("Животное", 2);
      animal.Sleep();
      animal.Eat();
      animal.MakeSound();

      var parrot = new Parrot("Гоша", 1);

      Console.WriteLine();

      var animals = new List<Animal>();
      animals.Add(animal);
      animals.Add(dog);
      animals.Add(cat);
      animals.Add(parrot);

      foreach (var item in animals)
      {
        item.Sleep();
        item.Eat();

        if (item is Parrot)
        {
          (item as Parrot).MakeSound();
        }
        else
        {
          item.MakeSound();
        }
      }

      Console.WriteLine();      

      var eagle = new Eagle();

      IFlyable[] birds = { parrot, eagle };
      for (int i = 0; i < birds.Length; i++)
      {
        birds[i].Fly();
      }

      Console.ReadLine();
    }
  }
}
