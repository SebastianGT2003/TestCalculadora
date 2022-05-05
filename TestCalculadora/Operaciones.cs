using Microsoft.VisualStudio.TestTools.UnitTesting;
using TestCalculadora;
using Proyecto1;

namespace TestCalculadora
{
    [TestClass]
    public class Operaciones
    {
        [TestMethod]
        public void Suma_De_Dos_Numeros()
        {
            //Arrange
            Calculadora calculadora = new Calculadora();




            //Act
            int Suma=calculadora.Sumar(9, 3);
            

            //Assert
            Assert.AreEqual(12, Suma);


        }
        [TestMethod]
        public void Resta_De_Dos_Numeros()
        {
            //Arrange
            Calculadora calculadora = new Calculadora();




            //Act
            int Resta = calculadora.Restar(9, 3);


            //Assert
            Assert.AreEqual(6, Resta);


        }
    }
}