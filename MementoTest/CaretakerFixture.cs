using Memento;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace MementoTest
{
    [TestClass]
    public class CaretakerFixture
    {
        [TestMethod]
        public void CaretakerMementoTest()
        {
            Originator originator = new Originator();
            originator.State = "Green";
            Caretaker caretaker = new Caretaker();
            caretaker.Memento = originator.CreateMemento();
            originator.State = "Red";
            originator.State = "Blue ";
            originator.State = "Yellow";

            originator.SetMemento(caretaker.Memento);

            string expected = "Green";

            string actual = originator.State;

            Assert.AreEqual(expected, actual);
        }
    }
}
