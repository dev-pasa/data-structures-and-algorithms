using System;
using FifoAnimalShelter.Classes;

namespace FifoAnimalShelter
{
    class Program
    {
        static void Main(string[] args)
        {
            Cat cat1 = new Cat("cat 1");
            Cat cat2 = new Cat("cat 2");
            Cat cat3 = new Cat("cat 3");
            Cat cat4 = new Cat("cat 4");
            Dog dog1 = new Dog("dog 1");
            Dog dog2 = new Dog("dog 2");
            Dog dog3 = new Dog("dog 3");
            

            AnimalShelter shelter = new AnimalShelter(dog1);
            shelter.Enqueue(cat1);
            shelter.Enqueue(dog2);
            shelter.Enqueue(dog3);
            shelter.Enqueue(cat2);
            shelter.Enqueue(cat3);
            shelter.Enqueue(cat4);

            Console.WriteLine($"First animal in queue is: {shelter.Peek().Value}");
            Console.WriteLine($"Check for first cat in queue: {shelter.Dequeue("cat").Value}");
            Console.WriteLine($"Check firt animal in queue even after previous dequeue: {shelter.Peek().Value}");
            
        }
    }
}
