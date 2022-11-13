using System;
using Library;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person1 = new Person("Juan", 34);
            Person person2 = new Person("Jose", 77);
            Person person3 = new Person("Pepe", 16);
            Person person4 = new Person("Maria", 22);
            Person person5 = new Person("Juana", 27);
            Person person6 = new Person("Josefa", 15);
            Person person7 = new Person("Martin", 65);
            Person person8 = new Person("Jesus", 37);

            Node<Person> nP1 = new Node<Person>(person1);
            Node<Person> nP2 = new Node<Person>(person2);
            Node<Person> nP3 = new Node<Person>(person3);
            Node<Person> nP4 = new Node<Person>(person4);
            Node<Person> nP5 = new Node<Person>(person5);
            Node<Person> nP6 = new Node<Person>(person6);
            Node<Person> nP7 = new Node<Person>(person7);
            Node<Person> nP8 = new Node<Person>(person8);

            nP1.AddChildren(nP2);
            nP1.AddChildren(nP3);

            nP2.AddChildren(nP4);
            nP2.AddChildren(nP5);
            nP2.AddChildren(nP6);

            nP3.AddChildren(nP7);
            nP3.AddChildren(nP8);    

            /// <summary>
            /// Get sum of all ages
            /// </summary>
            /// <returns></returns>

            AgeVisitor ageVisitor = new AgeVisitor();
            nP1.Accept(ageVisitor);
            System.Console.WriteLine($"La suma de todas las edades es {ageVisitor.sum}");

            /// <summary>
            /// Find oldest child
            /// </summary>
            /// <returns></returns>

            OldestChildVisitor oldestChildVisitor = new OldestChildVisitor();
            nP1.Accept(oldestChildVisitor);
            System.Console.WriteLine($"El hijo mayor es {oldestChildVisitor.oldestChild} con {oldestChildVisitor.oldestChild.age} años");

            /// <summary>
            /// Find person with longest name
            /// </summary>
            /// <returns></returns>
            LongestNameVisitor longestNameVisitor = new LongestNameVisitor();
            nP1.Accept(longestNameVisitor);
            System.Console.WriteLine($"La persona con el nombre más largo es {longestNameVisitor.personWithLongestName}");
        }
    }
}
