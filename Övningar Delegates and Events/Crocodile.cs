using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Övningar_Delegates_and_Events
{
    //1. ) 

    //Skapa en klass som representerar ett valfritt djur. Det ska ha minst två events som motsvarar saker som djuret gör. Skriv metoder i klassen
    //som anropar dina events vid rätt omständigheter.Testa genom att prenumerera på dina events med funktioner som skriver ut saker på konsolen.
    internal class Crocodile
    {
        // Event 1
        public event Action<string> Jump;
        // Event 2
        public event Action<string> Move;

        //Funktioner som ska prenumerera på eventen
        private void CrocodileJump(string text)
        {
            Console.WriteLine(text);
        }

        private void CrocodileMove(string text)
        {
            Console.WriteLine(text);
        }

        //Anropa Event 1 eller Event 2
        public void DoJump()
        {
            Console.WriteLine("Jumping!");
            Jump("Weird Crocodile who can jump");
        }
        public void DoMove()
        {
            Console.WriteLine("Moving!");
            Move("Crocodile is Moving!");
        }

        // Konstruktor
        public Crocodile()
        {
            // Prenumerera på Eventen Jump / Move med funktioner som skriver ut något(void) och tar exakt 1 Parameter av typen String.
            Jump += CrocodileJump;
            Move += CrocodileMove;
        }
    }
    //2. )

    //Skapa en klass som kan skriva ut saker på konsolen. Den ska ha ett event för händelsen att något skrivs ut. Skapa en ny klass,
    //som prenumererar på utskriftshändelsen.

    public class Writing
    {
        // Event för något som skrivs ut
        public event Action WritingSomething;

        public void Eating()
        {
            Console.WriteLine("Eating!");

            // Triggar eventet som skapar en kedja av prenumererade funktionsanrop
            WritingSomething();
        }

        public void Running()
        {
            Console.WriteLine("Running!");
        }
    }

    public class Prenumerera
    {
        public void Subscribed()
        {
            Console.WriteLine("Subscribed on Event WritingSomething");
        }

        public void AddingNewStuff()
        {
            // New stuff is coming here.
        }
    }
}
