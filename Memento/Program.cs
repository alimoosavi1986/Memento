using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Memento
{
    class Program
    {
        static void Main(string[] args)
        {
            Originator originator = new Originator();
            originator.State = "Green";
            Caretaker caretaker = new Caretaker();
            caretaker.Memento = originator.CreateMemento();
            originator.State = "Red";
            originator.State = "Blue ";
            originator.State = "Yellow";

            originator.SetMemento(caretaker.Memento);

            Console.Read();
        }
    }
}
