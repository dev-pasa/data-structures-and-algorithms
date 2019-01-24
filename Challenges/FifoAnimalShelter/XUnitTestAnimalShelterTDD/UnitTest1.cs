using System;
using Xunit;
using FifoAnimalShelter.Classes;

namespace XUnitTestAnimalShelterTDD
{
    public class UnitTest1
    {
        /// <summary>
        /// Check for first cat in the queue
        /// </summary>
        [Fact]
        public void DequeChecFirstCat()
        {
            Cat cat1 = new Cat("cat1");
            Dog dog1 = new Dog("dog1");
            Dog dog2 = new Dog("dog2");
            AnimalShelter shelter = new AnimalShelter(dog1);
            shelter.Enqueue(dog2);
            shelter.Enqueue(cat1);

            Assert.Equal("cat1", shelter.Dequeue("cat").Value);
        }
        /// <summary>
        /// Check for first cat in the queue
        /// </summary>
        [Fact]
        public void DequeChecFirstCat2()
        {
            Cat cat2 = new Cat("cat2");
            Dog dog1 = new Dog("dog1");
            Dog dog2 = new Dog("dog2");
            AnimalShelter shelter = new AnimalShelter(dog1);
            shelter.Enqueue(dog2);
            shelter.Enqueue(cat2);

            Assert.Equal("cat2", shelter.Dequeue("cat").Value);
        }
        /// <summary>
        /// Check for first cat in the queue
        /// </summary>
        [Fact]
        public void DequeChecFirstCat3()
        {
            Cat cat3 = new Cat("cat3");
            Dog dog1 = new Dog("dog1");
            Dog dog2 = new Dog("dog2");
            AnimalShelter shelter = new AnimalShelter(dog1);
            shelter.Enqueue(dog2);
            shelter.Enqueue(cat3);

            Assert.Equal("cat3", shelter.Dequeue("cat").Value);
        }

        /// <summary>
        /// check if other input still gives cat or dog
        /// </summary>
        [Fact]
        public void WrongInputFirstAnimal()
        {
            Cat cat1 = new Cat("cat1");
            Dog dog1 = new Dog("dog1");
            Dog dog2 = new Dog("dog2");
            AnimalShelter shelter = new AnimalShelter(cat1);
            shelter.Enqueue(dog2);
            shelter.Enqueue(dog1);

            Assert.Equal("cat1", shelter.Dequeue("sheep").Value);
        }

        /// <summary>
        /// check if other input still gives cat or dog
        /// </summary>
        [Fact]
        public void WrongInputFirstAnimal2()
        {
            Cat cat1 = new Cat("cat1");
            Dog dog1 = new Dog("dog1");
            Dog dog2 = new Dog("dog2");
            AnimalShelter shelter = new AnimalShelter(cat1);
            shelter.Enqueue(dog2);
            shelter.Enqueue(dog1);

            Assert.Equal("cat1", shelter.Dequeue("hen").Value);
        }

        /// <summary>
        /// check if other input still gives cat or dog
        /// </summary>
        [Fact]
        public void WrongInputFirstAnimal3()
        {
            Cat cat1 = new Cat("cat1");
            Dog dog1 = new Dog("dog1");
            Dog dog2 = new Dog("dog2");
            AnimalShelter shelter = new AnimalShelter(cat1);
            shelter.Enqueue(dog2);
            shelter.Enqueue(dog1);

            Assert.Equal("cat1", shelter.Dequeue("mouse").Value);
        }

        /// <summary>
        /// check if other input still gives cat or dog
        /// </summary>
        [Fact]
        public void Peek1()
        {
            Cat cat1 = new Cat("cat1");
            Dog dog1 = new Dog("dog1");
            Dog dog2 = new Dog("dog2");
            AnimalShelter shelter = new AnimalShelter(cat1);
            shelter.Enqueue(dog2);
            shelter.Enqueue(dog1);

            Assert.Equal("cat1", shelter.Peek().Value);
        }

        /// <summary>
        /// check if other input still gives cat or dog
        /// </summary>
        [Fact]
        public void Peek2()
        {
            Cat cat2 = new Cat("cat2");
            Dog dog1 = new Dog("dog1");
            Dog dog2 = new Dog("dog2");
            AnimalShelter shelter = new AnimalShelter(cat2);
            shelter.Enqueue(dog2);
            shelter.Enqueue(dog1);

            Assert.Equal("cat2", shelter.Peek().Value);
        }

        /// <summary>
        /// check if other input still gives cat or dog
        /// </summary>
        [Fact]
        public void Peek3()
        {
            Cat cat3 = new Cat("cat3");
            Dog dog1 = new Dog("dog1");
            Dog dog2 = new Dog("dog2");
            AnimalShelter shelter = new AnimalShelter(cat3);
            shelter.Enqueue(dog2);
            shelter.Enqueue(dog1);

            Assert.Equal("cat3", shelter.Peek().Value);
        }
    }
}
