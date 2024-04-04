using System;
using System.ComponentModel;
using System.Security.Cryptography.X509Certificates;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            // TODO Be sure to follow best practice when creating your classes

            // Create a class Animal
            // give this class 4 members that all Animals have in common


            // Create a class Bird
            // give this class 4 members that are specific to Bird
            // Set this class to inherit from your Animal Class

            // Create a class Reptile
            // give this class 4 members that are specific to Reptile
            // Set this class to inherit from your Animal Class




            /*Create an object of your Bird class
             *  give values to your members using the object of your Bird class
             *  
             * Creatively display the class member values 
             */
            Bird Magpie = new Bird("Magpie", "Forest", 1, 6, true, "black", 10, "sharp");

            //Googled how to print out all properties of a type
            foreach (PropertyDescriptor descriptor in TypeDescriptor.GetProperties(Magpie))
            {
                string name = descriptor.Name;
                object value = descriptor.GetValue(Magpie);
                Console.WriteLine("{0}={1}", name, value);
            }

            /*Create an object of your Reptile class
             *  give values to your members using the object of your Reptile class
             *  
             * Creatively display the class member values 
             */

            Reptile Tortoise = new Reptile("Tortoise", "Desert", 200, 500, "Brown", true, true, false);

            foreach (PropertyDescriptor descriptor in TypeDescriptor.GetProperties(Tortoise))
            {
                string name = descriptor.Name;
                object value = descriptor.GetValue(Tortoise);
                Console.WriteLine("{0}={1}", name, value);
            }
        }
    }
}
