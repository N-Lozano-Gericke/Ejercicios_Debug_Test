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
        public void Id_NotNull() 
        {
            var cedula = this.person.ID;
            var resultado = IdUtils.IdIsValid(cedula);
            bool resultadoesperado = true;
            Assert.AreEqual(resultadoesperado, cedula);
        
        }
        [Test]
        public void name_NotNull() 
        {
            var name = this.person.Name;
            var resultado = IdUtils.IdIsValid(name);
            bool resultadoesperado = true;
            Assert.AreEqual(resultadoesperado, name);
        
        }
         [Test]
        public void Id_Null() 
        {
            var cedula = this.person.ID;
            var resultado = IdUtils.IdIsValid(cedula);
            bool resultadoesperado = false;
            Assert.AreEqual(resultadoesperado, cedula);
        
        }
        [Test]
        public void name_Null() 
        {
            var name = this.person.Name;
            var resultado = IdUtils.IdIsValid(name);
            bool resultadoesperado = false;
            Assert.AreEqual(resultadoesperado, name);
        
        }
    }
}