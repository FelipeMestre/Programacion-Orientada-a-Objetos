using System;
using Xunit;
using Persona;

namespace Test
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            string nombre = "Felipe Mestre";
            Person Felipe = new Person(nombre,"49209164");
            Assert.Equal(Felipe.name,nombre);
        }
    }
}
