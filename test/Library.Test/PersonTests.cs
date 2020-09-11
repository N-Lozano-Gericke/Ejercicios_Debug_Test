using NUnit.Framework;

using UnitTestAndDebug;

namespace Tests
{
    public class PersonTests
    {
        private Person person;

        [SetUp]
        public void Setup()
        {
            this.person = new Person("Juan","5.599.661-2");
        }

        [Test]
        public void Id_NotNull() // Cambiá el nombre para indicar qué estás probando
        {
            var cedula = this.person.ID;
            
        }
    }
}