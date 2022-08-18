// See https://aka.ms/new-console-template for more information

namespace Övningar_Delegates_and_Events
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("In this program we are testing Delegates and Events!");
            Console.ReadKey(true);
            Crocodile myCrocodile = new Crocodile();
            myCrocodile.DoJump();
            myCrocodile.DoMove();
            Writing myWriting = new Writing();
            Prenumerera myPrenumerera = new Prenumerera();
            // "Subscribar" med olika funktioner i olika klasser på Eventet WritingSomething!
            myWriting.WritingSomething += myWriting.Running;
            myWriting.WritingSomething += myPrenumerera.Subscribed;
            // I denna funktion triggas en "kedja" av funktionsanrop genom eventet WritingSomething
            myWriting.Eating();

            Console.ReadKey(true);
        }
    }
}