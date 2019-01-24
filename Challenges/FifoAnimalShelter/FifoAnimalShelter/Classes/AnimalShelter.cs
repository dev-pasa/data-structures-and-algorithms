using System;
using System.Collections.Generic;
using System.Text;

namespace FifoAnimalShelter.Classes
{
    public class AnimalShelter
    {
        public Animal Front { get; set; }
        public Animal Rear { get; set; }

        /// <summary>
        /// point the front and rear of the animal
        /// </summary>
        /// <param name="animal"></param>
        public AnimalShelter(Animal animal)
        {
            Front = animal;
            Rear = animal;
        }

        /// <summary>
        /// return the value of the front of the queue
        /// </summary>
        /// <returns></returns>
        public Animal Peek()
        {
            return Front;
        }

        /// <summary>
        /// add value to the end of the queue
        /// </summary>
        /// <param name="animal"></param>
        public void Enqueue(Animal animal)
        {
            Rear.Next = animal;
            Rear = animal;
        }

        /// <summary>
        /// method to get the value from the end with temp reference
        /// </summary>
        /// <returns></returns>
        public Animal Dequeue()
        {
            Animal temp = Front;
            Front = Front.Next;
            temp.Next = null;
            return temp;
        }

        /// <summary>
        /// method overload to get the cat or dog object
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public Animal Dequeue(string input)
        {
            //return whatever is in the front
            if (input != "dog" && input != "cat")
                return Dequeue();

            //reference to the front of the queue
            Animal temp = Front;

            if (input == "dog")
            {
                if (Front is Dog)
                    return Dequeue();

                while (!(Front is Dog))
                {
                    Enqueue(Dequeue());
                    if (Front != temp)
                        return null;
                    //return null if no animal foound
                }
            }

            if (input == "cat")
            {
                if (Front is Cat)
                    return Dequeue();

                while (!(Front is Cat))
                {
                    Enqueue(Dequeue());
                    if (Front == temp)
                        return null;
                    //return null if no animal found 
                                     
                }
            }

            Animal result = Dequeue();
            while (Front != temp)
            {
                Enqueue(Dequeue());
            }

            return result;
        }
    }
}
